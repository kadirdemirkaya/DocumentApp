namespace DocumentPublishForm
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
            this.gbQueueExchangeBind = new System.Windows.Forms.GroupBox();
            this.gbExchanceDeclare = new System.Windows.Forms.GroupBox();
            this.txtHeaderContent = new System.Windows.Forms.TextBox();
            this.lblHeaderContent = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.cbExchangeDeclareType = new System.Windows.Forms.ComboBox();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.lblExchangeDeclareType = new System.Windows.Forms.Label();
            this.txtExchangeDeclareName = new System.Windows.Forms.TextBox();
            this.lblExchangeDeclareName = new System.Windows.Forms.Label();
            this.btnBindPublish = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.numericRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.lblRoutingKey = new System.Windows.Forms.Label();
            this.lblExchangeName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gbConnection.SuspendLayout();
            this.gbQueueExchangeBind.SuspendLayout();
            this.gbExchanceDeclare.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.gbConnection.Size = new System.Drawing.Size(810, 51);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "RabbitMQ Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(718, 16);
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
            this.txtConnectionString.Size = new System.Drawing.Size(579, 20);
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
            // gbQueueExchangeBind
            // 
            this.gbQueueExchangeBind.Controls.Add(this.gbExchanceDeclare);
            this.gbQueueExchangeBind.Location = new System.Drawing.Point(12, 69);
            this.gbQueueExchangeBind.Name = "gbQueueExchangeBind";
            this.gbQueueExchangeBind.Size = new System.Drawing.Size(396, 393);
            this.gbQueueExchangeBind.TabIndex = 1;
            this.gbQueueExchangeBind.TabStop = false;
            this.gbQueueExchangeBind.Text = "Queue / Exchange / Bind";
            // 
            // gbExchanceDeclare
            // 
            this.gbExchanceDeclare.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbExchanceDeclare.Controls.Add(this.txtHeaderContent);
            this.gbExchanceDeclare.Controls.Add(this.lblHeaderContent);
            this.gbExchanceDeclare.Controls.Add(this.lblHeader);
            this.gbExchanceDeclare.Controls.Add(this.txtHeader);
            this.gbExchanceDeclare.Controls.Add(this.cbExchangeDeclareType);
            this.gbExchanceDeclare.Controls.Add(this.btnDeclareExchange);
            this.gbExchanceDeclare.Controls.Add(this.lblExchangeDeclareType);
            this.gbExchanceDeclare.Controls.Add(this.txtExchangeDeclareName);
            this.gbExchanceDeclare.Controls.Add(this.lblExchangeDeclareName);
            this.gbExchanceDeclare.Location = new System.Drawing.Point(6, 29);
            this.gbExchanceDeclare.Name = "gbExchanceDeclare";
            this.gbExchanceDeclare.Size = new System.Drawing.Size(373, 358);
            this.gbExchanceDeclare.TabIndex = 1;
            this.gbExchanceDeclare.TabStop = false;
            this.gbExchanceDeclare.Text = "Exchange Declare";
            // 
            // txtHeaderContent
            // 
            this.txtHeaderContent.Location = new System.Drawing.Point(86, 285);
            this.txtHeaderContent.Name = "txtHeaderContent";
            this.txtHeaderContent.Size = new System.Drawing.Size(267, 20);
            this.txtHeaderContent.TabIndex = 26;
            // 
            // lblHeaderContent
            // 
            this.lblHeaderContent.AutoSize = true;
            this.lblHeaderContent.Location = new System.Drawing.Point(30, 288);
            this.lblHeaderContent.Name = "lblHeaderContent";
            this.lblHeaderContent.Size = new System.Drawing.Size(44, 13);
            this.lblHeaderContent.TabIndex = 25;
            this.lblHeaderContent.Text = "Content";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(32, 251);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(48, 13);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "Header :";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(86, 244);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(267, 20);
            this.txtHeader.TabIndex = 22;
            // 
            // cbExchangeDeclareType
            // 
            this.cbExchangeDeclareType.FormattingEnabled = true;
            this.cbExchangeDeclareType.Location = new System.Drawing.Point(100, 95);
            this.cbExchangeDeclareType.Name = "cbExchangeDeclareType";
            this.cbExchangeDeclareType.Size = new System.Drawing.Size(267, 21);
            this.cbExchangeDeclareType.TabIndex = 21;
            this.cbExchangeDeclareType.SelectedIndexChanged += new System.EventHandler(this.cbExchangeDeclareType_SelectedIndexChanged);
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.Location = new System.Drawing.Point(155, 192);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(133, 23);
            this.btnDeclareExchange.TabIndex = 20;
            this.btnDeclareExchange.Text = "Declare Exchange";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.btnDeclareExchange_Click);
            // 
            // lblExchangeDeclareType
            // 
            this.lblExchangeDeclareType.AutoSize = true;
            this.lblExchangeDeclareType.Location = new System.Drawing.Point(8, 98);
            this.lblExchangeDeclareType.Name = "lblExchangeDeclareType";
            this.lblExchangeDeclareType.Size = new System.Drawing.Size(88, 13);
            this.lblExchangeDeclareType.TabIndex = 18;
            this.lblExchangeDeclareType.Text = "Exchange Type :";
            // 
            // txtExchangeDeclareName
            // 
            this.txtExchangeDeclareName.Location = new System.Drawing.Point(100, 26);
            this.txtExchangeDeclareName.Name = "txtExchangeDeclareName";
            this.txtExchangeDeclareName.Size = new System.Drawing.Size(267, 20);
            this.txtExchangeDeclareName.TabIndex = 17;
            // 
            // lblExchangeDeclareName
            // 
            this.lblExchangeDeclareName.AutoSize = true;
            this.lblExchangeDeclareName.Location = new System.Drawing.Point(8, 29);
            this.lblExchangeDeclareName.Name = "lblExchangeDeclareName";
            this.lblExchangeDeclareName.Size = new System.Drawing.Size(92, 13);
            this.lblExchangeDeclareName.TabIndex = 16;
            this.lblExchangeDeclareName.Text = "Exchange Name :";
            // 
            // btnBindPublish
            // 
            this.btnBindPublish.Location = new System.Drawing.Point(104, 317);
            this.btnBindPublish.Name = "btnBindPublish";
            this.btnBindPublish.Size = new System.Drawing.Size(126, 23);
            this.btnBindPublish.TabIndex = 23;
            this.btnBindPublish.Text = "Publish";
            this.btnBindPublish.UseVisualStyleBackColor = true;
            this.btnBindPublish.Click += new System.EventHandler(this.btnBindPublish_Click);
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(838, 12);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(482, 444);
            this.gbLog.TabIndex = 3;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(9, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(467, 411);
            this.txtLog.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbMessage);
            this.pnlMain.Location = new System.Drawing.Point(414, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(418, 405);
            this.pnlMain.TabIndex = 4;
            // 
            // gbMessage
            // 
            this.gbMessage.BackColor = System.Drawing.Color.Red;
            this.gbMessage.Controls.Add(this.numericRepeatCount);
            this.gbMessage.Controls.Add(this.btnBindPublish);
            this.gbMessage.Controls.Add(this.txtMessage);
            this.gbMessage.Controls.Add(this.lblMessage);
            this.gbMessage.Controls.Add(this.txtRoutingKey);
            this.gbMessage.Controls.Add(this.txtExchangeName);
            this.gbMessage.Controls.Add(this.lblRoutingKey);
            this.gbMessage.Controls.Add(this.lblExchangeName);
            this.gbMessage.Location = new System.Drawing.Point(11, 6);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(397, 393);
            this.gbMessage.TabIndex = 5;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // numericRepeatCount
            // 
            this.numericRepeatCount.Location = new System.Drawing.Point(267, 317);
            this.numericRepeatCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericRepeatCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRepeatCount.Name = "numericRepeatCount";
            this.numericRepeatCount.Size = new System.Drawing.Size(103, 20);
            this.numericRepeatCount.TabIndex = 24;
            this.numericRepeatCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(104, 75);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(276, 223);
            this.txtMessage.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(33, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(56, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Message :";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(104, 45);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(276, 20);
            this.txtRoutingKey.TabIndex = 14;
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(104, 19);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(276, 20);
            this.txtExchangeName.TabIndex = 13;
            // 
            // lblRoutingKey
            // 
            this.lblRoutingKey.AutoSize = true;
            this.lblRoutingKey.Location = new System.Drawing.Point(18, 48);
            this.lblRoutingKey.Name = "lblRoutingKey";
            this.lblRoutingKey.Size = new System.Drawing.Size(71, 13);
            this.lblRoutingKey.TabIndex = 2;
            this.lblRoutingKey.Text = "Routing Key :";
            // 
            // lblExchangeName
            // 
            this.lblExchangeName.AutoSize = true;
            this.lblExchangeName.Location = new System.Drawing.Point(6, 22);
            this.lblExchangeName.Name = "lblExchangeName";
            this.lblExchangeName.Size = new System.Drawing.Size(92, 13);
            this.lblExchangeName.TabIndex = 1;
            this.lblExchangeName.Text = "Exchange Name :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1332, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLblConnectionStatus
            // 
            this.tsLblConnectionStatus.Name = "tsLblConnectionStatus";
            this.tsLblConnectionStatus.Size = new System.Drawing.Size(185, 17);
            this.tsLblConnectionStatus.Text = "Connection State: Not Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 487);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbQueueExchangeBind);
            this.Controls.Add(this.gbConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbQueueExchangeBind.ResumeLayout(false);
            this.gbExchanceDeclare.ResumeLayout(false);
            this.gbExchanceDeclare.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.GroupBox gbQueueExchangeBind;
        private System.Windows.Forms.GroupBox gbExchanceDeclare;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnBindPublish;
        private System.Windows.Forms.Button btnDeclareExchange;
        private System.Windows.Forms.Label lblExchangeDeclareType;
        private System.Windows.Forms.TextBox txtExchangeDeclareName;
        private System.Windows.Forms.Label lblExchangeDeclareName;
        private System.Windows.Forms.ComboBox cbExchangeDeclareType;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label lblRoutingKey;
        private System.Windows.Forms.Label lblExchangeName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblConnectionStatus;
        private System.Windows.Forms.NumericUpDown numericRepeatCount;
        private System.Windows.Forms.TextBox txtHeaderContent;
        private System.Windows.Forms.Label lblHeaderContent;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtHeader;
    }
}

