namespace ADSDemo
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRead = new Button();
            lblCounter = new Label();
            btnWrite = new Button();
            lblLED = new Label();
            lblLEDState = new Label();
            chkStartStop = new CheckBox();
            nudCounter = new NumericUpDown();
            lblAMSNetID = new Label();
            lblPort = new Label();
            txtAMSNetID = new TextBox();
            nudPort = new NumericUpDown();
            btnConnect = new Button();
            btnDisconnect = new Button();
            grbConnect = new GroupBox();
            grbOperations = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            grbConnect.SuspendLayout();
            grbOperations.SuspendLayout();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(255, 31);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(40, 33);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(53, 15);
            lblCounter.TabIndex = 1;
            lblCounter.Text = "Counter:";
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(255, 60);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(75, 23);
            btnWrite.TabIndex = 5;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lblLED
            // 
            lblLED.AutoSize = true;
            lblLED.Location = new Point(34, 118);
            lblLED.Name = "lblLED";
            lblLED.Size = new Size(59, 15);
            lblLED.TabIndex = 6;
            lblLED.Text = "LED State:";
            // 
            // lblLEDState
            // 
            lblLEDState.BorderStyle = BorderStyle.FixedSingle;
            lblLEDState.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLEDState.Location = new Point(99, 114);
            lblLEDState.Name = "lblLEDState";
            lblLEDState.Size = new Size(147, 23);
            lblLEDState.TabIndex = 7;
            lblLEDState.Text = "Off";
            lblLEDState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkStartStop
            // 
            chkStartStop.Appearance = Appearance.Button;
            chkStartStop.AutoSize = true;
            chkStartStop.Location = new Point(255, 113);
            chkStartStop.Name = "chkStartStop";
            chkStartStop.Size = new Size(70, 25);
            chkStartStop.TabIndex = 8;
            chkStartStop.Text = "Start/Stop";
            chkStartStop.UseVisualStyleBackColor = true;
            chkStartStop.CheckedChanged += chkStartStop_CheckedChanged;
            // 
            // nudCounter
            // 
            nudCounter.Location = new Point(99, 31);
            nudCounter.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCounter.Name = "nudCounter";
            nudCounter.Size = new Size(147, 23);
            nudCounter.TabIndex = 9;
            // 
            // lblAMSNetID
            // 
            lblAMSNetID.AutoSize = true;
            lblAMSNetID.Location = new Point(25, 30);
            lblAMSNetID.Name = "lblAMSNetID";
            lblAMSNetID.Size = new Size(68, 15);
            lblAMSNetID.TabIndex = 10;
            lblAMSNetID.Text = "AMS NetID:";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(61, 58);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(32, 15);
            lblPort.TabIndex = 11;
            lblPort.Text = "Port:";
            // 
            // txtAMSNetID
            // 
            txtAMSNetID.Location = new Point(99, 27);
            txtAMSNetID.Name = "txtAMSNetID";
            txtAMSNetID.Size = new Size(147, 23);
            txtAMSNetID.TabIndex = 12;
            txtAMSNetID.Text = "127.0.0.1.1.1";
            // 
            // nudPort
            // 
            nudPort.Location = new Point(99, 56);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(147, 23);
            nudPort.TabIndex = 13;
            nudPort.Value = new decimal(new int[] { 851, 0, 0, 0 });
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(255, 27);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 14;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(255, 56);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 15;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // grbConnect
            // 
            grbConnect.Controls.Add(lblAMSNetID);
            grbConnect.Controls.Add(btnDisconnect);
            grbConnect.Controls.Add(lblPort);
            grbConnect.Controls.Add(btnConnect);
            grbConnect.Controls.Add(txtAMSNetID);
            grbConnect.Controls.Add(nudPort);
            grbConnect.Location = new Point(12, 12);
            grbConnect.Name = "grbConnect";
            grbConnect.Size = new Size(349, 98);
            grbConnect.TabIndex = 16;
            grbConnect.TabStop = false;
            grbConnect.Text = "Connect to PLC";
            // 
            // grbOperations
            // 
            grbOperations.Controls.Add(lblCounter);
            grbOperations.Controls.Add(btnRead);
            grbOperations.Controls.Add(chkStartStop);
            grbOperations.Controls.Add(nudCounter);
            grbOperations.Controls.Add(lblLEDState);
            grbOperations.Controls.Add(btnWrite);
            grbOperations.Controls.Add(lblLED);
            grbOperations.Enabled = false;
            grbOperations.Location = new Point(12, 116);
            grbOperations.Name = "grbOperations";
            grbOperations.Size = new Size(349, 158);
            grbOperations.TabIndex = 17;
            grbOperations.TabStop = false;
            grbOperations.Text = "Operations";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 287);
            Controls.Add(grbOperations);
            Controls.Add(grbConnect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Ads Demo";
            FormClosed += FormMain_FormClosed;
            ((System.ComponentModel.ISupportInitialize)nudCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPort).EndInit();
            grbConnect.ResumeLayout(false);
            grbConnect.PerformLayout();
            grbOperations.ResumeLayout(false);
            grbOperations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Label lblCounter;
        private Button btnWrite;
        private Label lblLED;
        private Label lblLEDState;
        private CheckBox chkStartStop;
        private NumericUpDown nudCounter;
        private Label lblAMSNetID;
        private Label lblPort;
        private TextBox txtAMSNetID;
        private NumericUpDown nudPort;
        private Button btnConnect;
        private Button btnDisconnect;
        private GroupBox grbConnect;
        private GroupBox grbOperations;
    }
}
