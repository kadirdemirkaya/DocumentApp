using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DocumentConsumeForm.Files;
using DocumentConsumeForm.Enums;

namespace DocumentConsumeForm
{
    public partial class Form1 : Form
    {
        private static string connectionString = "amqp://guest:guest@localhost:5672";
        private static IConnection connection;
        private static IModel _channel;
        private static IModel channel => _channel ?? (CreateOrGetChannel());

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
            }
        }

        public Form1()
        {
            InitializeComponent();

            Initialize();

            RabbitmqConnection();

            channel.BasicQos(0, 5, false);
        }

        private void Initialize()
        {
            dbFileType.Items.Add("Pdf");
            dbFileType.Items.Add("Text");
            dbFileType.Items.Add("Json");
        }

        private void btnQueueNameCreate_Click(object sender, EventArgs e)
        {
            //channel.QueueDeclare(txtQueueName.Text, exclusive: false,arguments: _ttl);
            channel.QueueDeclare(txtQueueName.Text, exclusive: false,autoDelete:false,arguments: _ttl);
            AddLog($"Declare Queue : {txtQueueName.Text}", Color.Blue);
        }

        private static IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            RabbitmqConnection();
        }

        private void RabbitmqConnection()
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

        private void btnQueueBind_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtQueueName.Text, txtExchangeName.Text, txtRoutingKey.Text ?? string.Empty);
            AddLog($"Binded Exchange : {txtExchangeName.Text} --- Queue : {txtQueueName.Text}", Color.Blue);
        }

        private void btnFileTypeCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var consumerEvent = new EventingBasicConsumer(channel);

                consumerEvent.Received += (ch, ee) =>
                {
                    var byteArr = ee.Body.ToArray();
                    var bodyStr = Encoding.UTF8.GetString(byteArr);

                    bool result = FilesCreate.FileCreate(dbFileType.Text, bodyStr, txtFilePath.Text);
                    if (result)
                    {
                        channel.BasicAck(ee.DeliveryTag, false); //this succesfully process 
                        AddLog($"CONSUME DATA -=> {bodyStr ?? "NULL DATA"} and file type -=> {dbFileType.Text}", Color.Aqua);//CONSUMEYI LOGA YAZDIR
                    }
                    else
                    {
                        channel.BasicNack(ee.DeliveryTag, false, true); //this unsuccesfully process 
                        AddLog($"NOT CONSUME DATA !!!", Color.Red);
                    }

                };
                //channel.BasicConsume(txtQueueName.Text, false, consumerEvent);
                channel.BasicConsume(txtQueueName.Text, false, consumerEvent);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR : " + ex.Message);
            }
        }
        private void AddLog(string logStr, Color color)
        {
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.AppendText($"{logStr}\n");
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ForeColor = color;
            txtLog.ScrollToCaret();
        }

        private void btnBindAndConsume_Click(object sender, EventArgs e)
        {
           try
           {
                channel.QueueBind(txtQueueProperty.Text, txtExchangeProperty.Text, txtRoutingKeyProperty.Text ?? string.Empty);
                AddLog($"BINDED EXCHANGE : {txtExchangeProperty.Text} --- QUEUE : {txtQueueProperty.Text}", Color.Blue);

                var consumerEvent = new EventingBasicConsumer(channel);
                consumerEvent.Received += (ch, ee) =>
                {
                    var byteArr = ee.Body.ToArray();
                    var bodyStr = Encoding.UTF8.GetString(byteArr);

                    AddLog($"CONSUME DATA -=> {bodyStr ?? "NULL DATA"} and file type -=> {dbFileType.Text}", Color.Aqua);

                    channel.BasicAck(ee.DeliveryTag, false);
                };
                //channel.BasicConsume(txtQueueProperty.Text, false, consumerEvent);
                channel.BasicConsume(txtQueueProperty.Text, true, consumerEvent);
           }
           catch(Exception ex)
           {
                Console.WriteLine("ERROR : " + ex.Message);
           }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RabbitmqConnection();
        }
    }
}
