using DocumentPublishForm.Enums;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DocumentPublishForm
{

    public partial class Form1 : Form
    {
        IBasicProperties basicProperties;
        Dictionary<string, object> header = new Dictionary<string, object>();
        Dictionary<string, object> _ttl = new Dictionary<string, object>()
        {
            {"message-ttl",60000}
        };
        private bool _isConnectionOpen;
        private bool isConnectionOpen
        {
            get => _isConnectionOpen;

            set
            {
                _isConnectionOpen = value;
                ConnectionStateChanged();
            }
        }

        private IConnection connection;

        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateOrGetChannel());

        public Form1()
        {
            InitializeComponent();
            Initialize();
            RabbitMQConnection();

            txtHeader.Visible = false;
            txtHeaderContent.Visible = false;
            lblHeader.Visible = false;
            lblHeaderContent.Visible = false;

            DateTime currentTime = DateTime.UtcNow;
            long unixTimestamp = (long)(currentTime.Subtract(new DateTime(2023, 8, 17))).TotalSeconds;
            basicProperties = channel.CreateBasicProperties();
            basicProperties.ContentType = "JSON";
            basicProperties.DeliveryMode = 1;
            basicProperties.Expiration = "60000";
            basicProperties.Timestamp = new AmqpTimestamp(unixTimestamp);
        }

        private IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Disconnect" : "Connect";

            UpdateConnectionStatus();

            pnlMain.Enabled = gbQueueExchangeBind.Enabled = isConnectionOpen;
        }

        private void UpdateConnectionStatus()
        {
            string state = $"{(isConnectionOpen ? "" : "Not ")}Connected";
            tsLblConnectionStatus.Text = $"Connection State: {state}";
            AddLog($"Connection state is {state}",Color.Blue);
        }

        private void AddLog(string logStr, Color color)
        {
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.AppendText($"{logStr}\n");
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ForeColor = color;
            txtLog.ScrollToCaret();
        }

        private void Initialize()
        {
            cbExchangeDeclareType.Items.Add("direct");
            cbExchangeDeclareType.Items.Add("fanout");
            cbExchangeDeclareType.Items.Add("topic");
            cbExchangeDeclareType.Items.Add("headers");
            cbExchangeDeclareType.SelectedIndex = 0;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RabbitMQConnection();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            RabbitMQConnection();
        }

        private void RabbitMQConnection()
        {
            if (!isConnectionOpen || connection == null)
            {
                connection = GetConnection();
                txtLog.Clear();
                AddLog($"RabbitMQ Connected !", Color.Green);
            }
            else
            {
                connection.Close();
                txtLog.Clear();
                AddLog($"RabbitMQ Disconnected !", Color.Red);
            }

            isConnectionOpen = connection.IsOpen;
        }

        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }

        private void btnDeclareExchange_Click(object sender, EventArgs e)
        {
            //channel.ExchangeDeclare(txtExchangeDeclareName.Text, cbExchangeDeclareType.Text,autoDelete:true,arguments: _ttl);
            //channel.ExchangeDeclare(txtExchangeDeclareName.Text, cbExchangeDeclareType.Text, autoDelete: true);
            channel.ExchangeDeclare(txtExchangeDeclareName.Text, cbExchangeDeclareType.Text, autoDelete: false,arguments:header ?? null);
            header.Clear();
            AddLog($"Exchange created with Name: {txtExchangeDeclareName.Text}, Type: {cbExchangeDeclareType.Text}", Color.Blue);
        }

        

        private void btnBindPublish_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;
            for (int i = 0; i < numericRepeatCount.Value; i++)
            {
                message = $"\n[{i + 1}] - {txtMessage.Text}";
                PublishDataToExchange(txtExchangeName.Text, txtRoutingKey.Text ?? string.Empty, message);
            }
            AddLog($"Send Messsage to RabbitMQ !", Color.Green);
        }

        private void PublishDataToExchange(string exchangeName, string routingKey, object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));

            channel.BasicPublish(exchangeName, routingKey, basicProperties, dataArr);
        }

        private void cbExchangeDeclareType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbExchangeDeclareType.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exchangeType = cbExchangeDeclareType.SelectedItem.ToString();
            if (exchangeType == "headers")
            {
                txtHeader.Visible = true;
                txtHeaderContent.Visible = true;
                lblHeader.Visible = true;
                lblHeaderContent.Visible = true;
                header.Add(txtHeader.Text, txtHeaderContent.Text);
            }
        }
    }
}
