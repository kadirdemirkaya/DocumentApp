namespace DocumentConsumeForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.gbFileTypes = new System.Windows.Forms.GroupBox();
            this.btnFileTypeCreate = new System.Windows.Forms.Button();
            this.lblFileType = new System.Windows.Forms.Label();
            this.dbFileType = new System.Windows.Forms.ComboBox();
            this.gbQueueDeclare = new System.Windows.Forms.GroupBox();
            this.btnQueueNameCreate = new System.Windows.Forms.Button();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.lblQueueName = new System.Windows.Forms.Label();
            this.gbExchangeQueueBind = new System.Windows.Forms.GroupBox();
            this.btnQueueBind = new System.Windows.Forms.Button();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.lblRoutingKey = new System.Windows.Forms.Label();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.lblExchangeName = new System.Windows.Forms.Label();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBindAndConsume = new System.Windows.Forms.Button();
            this.txtRoutingKeyProperty = new System.Windows.Forms.TextBox();
            this.lblRoutingKeyProperty = new System.Windows.Forms.Label();
            this.txtExchangeProperty = new System.Windows.Forms.TextBox();
            this.lblExchangeProperty = new System.Windows.Forms.Label();
            this.txtQueueProperty = new System.Windows.Forms.TextBox();
            this.lblQueueProperty = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.gbConnection.SuspendLayout();
            this.gbFileTypes.SuspendLayout();
            this.gbQueueDeclare.SuspendLayout();
            this.gbExchangeQueueBind.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.BackColor = System.Drawing.Color.DarkOrange;
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.txtConnectionString);
            this.gbConnection.Controls.Add(this.lblConnectionString);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(713, 51);
            this.gbConnection.TabIndex = 1;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "RabbitMQ Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(594, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(114, 19);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(442, 20);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(11, 22);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(97, 13);
            this.lblConnectionString.TabIndex = 0;
            this.lblConnectionString.Text = "Connection String :";
            // 
            // gbFileTypes
            // 
            this.gbFileTypes.BackColor = System.Drawing.Color.OliveDrab;
            this.gbFileTypes.Controls.Add(this.lblPath);
            this.gbFileTypes.Controls.Add(this.txtFilePath);
            this.gbFileTypes.Controls.Add(this.btnFileTypeCreate);
            this.gbFileTypes.Controls.Add(this.lblFileType);
            this.gbFileTypes.Controls.Add(this.dbFileType);
            this.gbFileTypes.Location = new System.Drawing.Point(12, 296);
            this.gbFileTypes.Name = "gbFileTypes";
            this.gbFileTypes.Size = new System.Drawing.Size(713, 90);
            this.gbFileTypes.TabIndex = 2;
            this.gbFileTypes.TabStop = false;
            this.gbFileTypes.Text = "File Types";
            // 
            // btnFileTypeCreate
            // 
            this.btnFileTypeCreate.Location = new System.Drawing.Point(152, 46);
            this.btnFileTypeCreate.Name = "btnFileTypeCreate";
            this.btnFileTypeCreate.Size = new System.Drawing.Size(90, 30);
            this.btnFileTypeCreate.TabIndex = 3;
            this.btnFileTypeCreate.Text = "Create File";
            this.btnFileTypeCreate.UseVisualStyleBackColor = true;
            this.btnFileTypeCreate.Click += new System.EventHandler(this.btnFileTypeCreate_Click);
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(14, 22);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(61, 13);
            this.lblFileType.TabIndex = 1;
            this.lblFileType.Text = "File Types :";
            // 
            // dbFileType
            // 
            this.dbFileType.FormattingEnabled = true;
            this.dbFileType.Location = new System.Drawing.Point(81, 19);
            this.dbFileType.Name = "dbFileType";
            this.dbFileType.Size = new System.Drawing.Size(261, 21);
            this.dbFileType.TabIndex = 0;
            // 
            // gbQueueDeclare
            // 
            this.gbQueueDeclare.BackColor = System.Drawing.Color.SpringGreen;
            this.gbQueueDeclare.Controls.Add(this.btnQueueNameCreate);
            this.gbQueueDeclare.Controls.Add(this.txtQueueName);
            this.gbQueueDeclare.Controls.Add(this.lblQueueName);
            this.gbQueueDeclare.Location = new System.Drawing.Point(13, 69);
            this.gbQueueDeclare.Name = "gbQueueDeclare";
            this.gbQueueDeclare.Size = new System.Drawing.Size(713, 87);
            this.gbQueueDeclare.TabIndex = 3;
            this.gbQueueDeclare.TabStop = false;
            this.gbQueueDeclare.Text = "Queue Declare";
            // 
            // btnQueueNameCreate
            // 
            this.btnQueueNameCreate.Location = new System.Drawing.Point(311, 45);
            this.btnQueueNameCreate.Name = "btnQueueNameCreate";
            this.btnQueueNameCreate.Size = new System.Drawing.Size(90, 30);
            this.btnQueueNameCreate.TabIndex = 7;
            this.btnQueueNameCreate.Text = "Declare Queue";
            this.btnQueueNameCreate.UseVisualStyleBackColor = true;
            this.btnQueueNameCreate.Click += new System.EventHandler(this.btnQueueNameCreate_Click);
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(239, 19);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(253, 20);
            this.txtQueueName.TabIndex = 1;
            // 
            // lblQueueName
            // 
            this.lblQueueName.AutoSize = true;
            this.lblQueueName.Location = new System.Drawing.Point(163, 22);
            this.lblQueueName.Name = "lblQueueName";
            this.lblQueueName.Size = new System.Drawing.Size(76, 13);
            this.lblQueueName.TabIndex = 0;
            this.lblQueueName.Text = "Queue Name :";
            // 
            // gbExchangeQueueBind
            // 
            this.gbExchangeQueueBind.BackColor = System.Drawing.Color.Crimson;
            this.gbExchangeQueueBind.Controls.Add(this.btnQueueBind);
            this.gbExchangeQueueBind.Controls.Add(this.txtRoutingKey);
            this.gbExchangeQueueBind.Controls.Add(this.lblRoutingKey);
            this.gbExchangeQueueBind.Controls.Add(this.txtExchangeName);
            this.gbExchangeQueueBind.Controls.Add(this.lblExchangeName);
            this.gbExchangeQueueBind.Location = new System.Drawing.Point(12, 162);
            this.gbExchangeQueueBind.Name = "gbExchangeQueueBind";
            this.gbExchangeQueueBind.Size = new System.Drawing.Size(712, 128);
            this.gbExchangeQueueBind.TabIndex = 4;
            this.gbExchangeQueueBind.TabStop = false;
            this.gbExchangeQueueBind.Text = "Exchange/Queue Bind";
            // 
            // btnQueueBind
            // 
            this.btnQueueBind.Location = new System.Drawing.Point(310, 80);
            this.btnQueueBind.Name = "btnQueueBind";
            this.btnQueueBind.Size = new System.Drawing.Size(90, 30);
            this.btnQueueBind.TabIndex = 6;
            this.btnQueueBind.Text = "Queue Bind";
            this.btnQueueBind.UseVisualStyleBackColor = true;
            this.btnQueueBind.Click += new System.EventHandler(this.btnQueueBind_Click);
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(239, 45);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(253, 20);
            this.txtRoutingKey.TabIndex = 5;
            // 
            // lblRoutingKey
            // 
            this.lblRoutingKey.AutoSize = true;
            this.lblRoutingKey.Location = new System.Drawing.Point(162, 48);
            this.lblRoutingKey.Name = "lblRoutingKey";
            this.lblRoutingKey.Size = new System.Drawing.Size(71, 13);
            this.lblRoutingKey.TabIndex = 4;
            this.lblRoutingKey.Text = "Routing Key :";
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(238, 19);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(253, 20);
            this.txtExchangeName.TabIndex = 3;
            // 
            // lblExchangeName
            // 
            this.lblExchangeName.AutoSize = true;
            this.lblExchangeName.Location = new System.Drawing.Point(146, 22);
            this.lblExchangeName.Name = "lblExchangeName";
            this.lblExchangeName.Size = new System.Drawing.Size(92, 13);
            this.lblExchangeName.TabIndex = 2;
            this.lblExchangeName.Text = "Exchange Name :";
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(732, 12);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(516, 569);
            this.gbLog.TabIndex = 5;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(20, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(480, 544);
            this.txtLog.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.btnBindAndConsume);
            this.groupBox1.Controls.Add(this.txtRoutingKeyProperty);
            this.groupBox1.Controls.Add(this.lblRoutingKeyProperty);
            this.groupBox1.Controls.Add(this.txtExchangeProperty);
            this.groupBox1.Controls.Add(this.lblExchangeProperty);
            this.groupBox1.Controls.Add(this.txtQueueProperty);
            this.groupBox1.Controls.Add(this.lblQueueProperty);
            this.groupBox1.Location = new System.Drawing.Point(13, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Types";
            // 
            // btnBindAndConsume
            // 
            this.btnBindAndConsume.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBindAndConsume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBindAndConsume.Location = new System.Drawing.Point(128, 144);
            this.btnBindAndConsume.Name = "btnBindAndConsume";
            this.btnBindAndConsume.Size = new System.Drawing.Size(253, 30);
            this.btnBindAndConsume.TabIndex = 13;
            this.btnBindAndConsume.Text = "Bind And Consume";
            this.btnBindAndConsume.UseVisualStyleBackColor = false;
            this.btnBindAndConsume.Click += new System.EventHandler(this.btnBindAndConsume_Click);
            // 
            // txtRoutingKeyProperty
            // 
            this.txtRoutingKeyProperty.Location = new System.Drawing.Point(128, 103);
            this.txtRoutingKeyProperty.Name = "txtRoutingKeyProperty";
            this.txtRoutingKeyProperty.Size = new System.Drawing.Size(253, 20);
            this.txtRoutingKeyProperty.TabIndex = 12;
            // 
            // lblRoutingKeyProperty
            // 
            this.lblRoutingKeyProperty.AutoSize = true;
            this.lblRoutingKeyProperty.Location = new System.Drawing.Point(9, 106);
            this.lblRoutingKeyProperty.Name = "lblRoutingKeyProperty";
            this.lblRoutingKeyProperty.Size = new System.Drawing.Size(110, 13);
            this.lblRoutingKeyProperty.TabIndex = 10;
            this.lblRoutingKeyProperty.Text = "RoutingKey Property :";
            // 
            // txtExchangeProperty
            // 
            this.txtExchangeProperty.Location = new System.Drawing.Point(128, 61);
            this.txtExchangeProperty.Name = "txtExchangeProperty";
            this.txtExchangeProperty.Size = new System.Drawing.Size(253, 20);
            this.txtExchangeProperty.TabIndex = 9;
            // 
            // lblExchangeProperty
            // 
            this.lblExchangeProperty.AutoSize = true;
            this.lblExchangeProperty.Location = new System.Drawing.Point(16, 64);
            this.lblExchangeProperty.Name = "lblExchangeProperty";
            this.lblExchangeProperty.Size = new System.Drawing.Size(103, 13);
            this.lblExchangeProperty.TabIndex = 7;
            this.lblExchangeProperty.Text = "Exchange Property :";
            // 
            // txtQueueProperty
            // 
            this.txtQueueProperty.Location = new System.Drawing.Point(128, 19);
            this.txtQueueProperty.Name = "txtQueueProperty";
            this.txtQueueProperty.Size = new System.Drawing.Size(253, 20);
            this.txtQueueProperty.TabIndex = 6;
            // 
            // lblQueueProperty
            // 
            this.lblQueueProperty.AutoSize = true;
            this.lblQueueProperty.Location = new System.Drawing.Point(32, 22);
            this.lblQueueProperty.Name = "lblQueueProperty";
            this.lblQueueProperty.Size = new System.Drawing.Size(87, 13);
            this.lblQueueProperty.TabIndex = 1;
            this.lblQueueProperty.Text = "Queue Property :";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(454, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(253, 20);
            this.txtFilePath.TabIndex = 6;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(385, 22);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(54, 13);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "File Path :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbExchangeQueueBind);
            this.Controls.Add(this.gbQueueDeclare);
            this.Controls.Add(this.gbFileTypes);
            this.Controls.Add(this.gbConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbFileTypes.ResumeLayout(false);
            this.gbFileTypes.PerformLayout();
            this.gbQueueDeclare.ResumeLayout(false);
            this.gbQueueDeclare.PerformLayout();
            this.gbExchangeQueueBind.ResumeLayout(false);
            this.gbExchangeQueueBind.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.GroupBox gbFileTypes;
        private System.Windows.Forms.ComboBox dbFileType;
        private System.Windows.Forms.Button btnFileTypeCreate;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.GroupBox gbQueueDeclare;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.Label lblQueueName;
        private System.Windows.Forms.GroupBox gbExchangeQueueBind;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Label lblRoutingKey;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label lblExchangeName;
        private System.Windows.Forms.Button btnQueueNameCreate;
        private System.Windows.Forms.Button btnQueueBind;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExchangeProperty;
        private System.Windows.Forms.Label lblExchangeProperty;
        private System.Windows.Forms.TextBox txtQueueProperty;
        private System.Windows.Forms.Label lblQueueProperty;
        private System.Windows.Forms.Button btnBindAndConsume;
        private System.Windows.Forms.TextBox txtRoutingKeyProperty;
        private System.Windows.Forms.Label lblRoutingKeyProperty;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}

