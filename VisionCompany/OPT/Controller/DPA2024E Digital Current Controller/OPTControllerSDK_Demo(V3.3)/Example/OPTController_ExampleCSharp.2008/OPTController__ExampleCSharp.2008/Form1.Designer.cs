namespace OPTController__ExampleCSharp._2008
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_IP = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_SN = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_COMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_SerialPort = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ChannelIndex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_OpenChannel = new System.Windows.Forms.Button();
            this.button_CloseChannel = new System.Windows.Forms.Button();
            this.buttonSetIntensity = new System.Windows.Forms.Button();
            this.textBox_Intensity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SetCurrent = new System.Windows.Forms.Button();
            this.btn_SetIP = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReadTriggerMode = new System.Windows.Forms.Button();
            this.btn_SetTriggerMode = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ReadTable = new System.Windows.Forms.Button();
            this.btn_SetTable = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_TriggerMode = new System.Windows.Forms.Button();
            this.radioBtn_Programmable = new System.Windows.Forms.RadioButton();
            this.radioBtn_General = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_Open);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButton_IP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_SN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton_SN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_COMName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_SerialPort);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 220);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "ResetConnection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(8, 178);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(93, 23);
            this.button_Open.TabIndex = 25;
            this.button_Open.Text = "Connect";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "(e.g.:\"192.168.18.12\")";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(107, 148);
            this.textBox_IP.MaxLength = 16;
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 21);
            this.textBox_IP.TabIndex = 23;
            this.textBox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "IP Address";
            // 
            // radioButton_IP
            // 
            this.radioButton_IP.AutoSize = true;
            this.radioButton_IP.Location = new System.Drawing.Point(16, 122);
            this.radioButton_IP.Name = "radioButton_IP";
            this.radioButton_IP.Size = new System.Drawing.Size(185, 16);
            this.radioButton_IP.TabIndex = 21;
            this.radioButton_IP.TabStop = true;
            this.radioButton_IP.Text = "Ethernet Communiction By IP";
            this.radioButton_IP.UseVisualStyleBackColor = true;
            this.radioButton_IP.CheckedChanged += new System.EventHandler(this.radioButton_IP_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "(e.g.:\"ffffffff01\")";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Location = new System.Drawing.Point(59, 95);
            this.textBox_SN.MaxLength = 10;
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(100, 21);
            this.textBox_SN.TabIndex = 19;
            this.textBox_SN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "SN";
            // 
            // radioButton_SN
            // 
            this.radioButton_SN.AutoSize = true;
            this.radioButton_SN.Location = new System.Drawing.Point(16, 74);
            this.radioButton_SN.Name = "radioButton_SN";
            this.radioButton_SN.Size = new System.Drawing.Size(191, 16);
            this.radioButton_SN.TabIndex = 17;
            this.radioButton_SN.TabStop = true;
            this.radioButton_SN.Text = "Ethernet Communication By SN";
            this.radioButton_SN.UseVisualStyleBackColor = true;
            this.radioButton_SN.CheckedChanged += new System.EventHandler(this.radioButton_SN_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "(e.g.\"COM1\")";
            // 
            // textBox_COMName
            // 
            this.textBox_COMName.Location = new System.Drawing.Point(137, 47);
            this.textBox_COMName.MaxLength = 5;
            this.textBox_COMName.Name = "textBox_COMName";
            this.textBox_COMName.Size = new System.Drawing.Size(100, 21);
            this.textBox_COMName.TabIndex = 15;
            this.textBox_COMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serialport Name";
            // 
            // radioButton_SerialPort
            // 
            this.radioButton_SerialPort.AutoSize = true;
            this.radioButton_SerialPort.Location = new System.Drawing.Point(16, 25);
            this.radioButton_SerialPort.Name = "radioButton_SerialPort";
            this.radioButton_SerialPort.Size = new System.Drawing.Size(167, 16);
            this.radioButton_SerialPort.TabIndex = 13;
            this.radioButton_SerialPort.TabStop = true;
            this.radioButton_SerialPort.Text = "SerialPort Communication";
            this.radioButton_SerialPort.UseVisualStyleBackColor = true;
            this.radioButton_SerialPort.CheckedChanged += new System.EventHandler(this.radioButton_SerialPort_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "ChannelIndex";
            // 
            // textBox_ChannelIndex
            // 
            this.textBox_ChannelIndex.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ChannelIndex.Location = new System.Drawing.Point(137, 23);
            this.textBox_ChannelIndex.MaxLength = 2;
            this.textBox_ChannelIndex.Name = "textBox_ChannelIndex";
            this.textBox_ChannelIndex.Size = new System.Drawing.Size(114, 21);
            this.textBox_ChannelIndex.TabIndex = 15;
            this.textBox_ChannelIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "(Range:[0-16])";
            // 
            // button_OpenChannel
            // 
            this.button_OpenChannel.Location = new System.Drawing.Point(8, 50);
            this.button_OpenChannel.Name = "button_OpenChannel";
            this.button_OpenChannel.Size = new System.Drawing.Size(111, 23);
            this.button_OpenChannel.TabIndex = 17;
            this.button_OpenChannel.Text = "Turn On Channel";
            this.button_OpenChannel.UseVisualStyleBackColor = true;
            this.button_OpenChannel.Click += new System.EventHandler(this.button_OpenChannel_Click);
            // 
            // button_CloseChannel
            // 
            this.button_CloseChannel.Location = new System.Drawing.Point(137, 50);
            this.button_CloseChannel.Name = "button_CloseChannel";
            this.button_CloseChannel.Size = new System.Drawing.Size(114, 23);
            this.button_CloseChannel.TabIndex = 18;
            this.button_CloseChannel.Text = "Turn Off Channel";
            this.button_CloseChannel.UseVisualStyleBackColor = true;
            this.button_CloseChannel.Click += new System.EventHandler(this.button_CloseChannel_Click);
            // 
            // buttonSetIntensity
            // 
            this.buttonSetIntensity.Location = new System.Drawing.Point(8, 80);
            this.buttonSetIntensity.Name = "buttonSetIntensity";
            this.buttonSetIntensity.Size = new System.Drawing.Size(111, 23);
            this.buttonSetIntensity.TabIndex = 19;
            this.buttonSetIntensity.Text = "SetIntensity";
            this.buttonSetIntensity.UseVisualStyleBackColor = true;
            this.buttonSetIntensity.Click += new System.EventHandler(this.buttonSetIntensity_Click);
            // 
            // textBox_Intensity
            // 
            this.textBox_Intensity.Location = new System.Drawing.Point(137, 80);
            this.textBox_Intensity.MaxLength = 3;
            this.textBox_Intensity.Name = "textBox_Intensity";
            this.textBox_Intensity.Size = new System.Drawing.Size(114, 21);
            this.textBox_Intensity.TabIndex = 20;
            this.textBox_Intensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "(Range:[0-255])";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SetCurrent);
            this.groupBox2.Controls.Add(this.btn_SetIP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_ChannelIndex);
            this.groupBox2.Controls.Add(this.textBox_Intensity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonSetIntensity);
            this.groupBox2.Controls.Add(this.button_OpenChannel);
            this.groupBox2.Controls.Add(this.button_CloseChannel);
            this.groupBox2.Location = new System.Drawing.Point(13, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 149);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller Operations";
            // 
            // btn_SetCurrent
            // 
            this.btn_SetCurrent.Location = new System.Drawing.Point(137, 107);
            this.btn_SetCurrent.Name = "btn_SetCurrent";
            this.btn_SetCurrent.Size = new System.Drawing.Size(114, 23);
            this.btn_SetCurrent.TabIndex = 28;
            this.btn_SetCurrent.Text = "SetCurrent";
            this.btn_SetCurrent.UseVisualStyleBackColor = true;
            this.btn_SetCurrent.Click += new System.EventHandler(this.btn_SetCurrent_Click);
            // 
            // btn_SetIP
            // 
            this.btn_SetIP.Location = new System.Drawing.Point(8, 109);
            this.btn_SetIP.Name = "btn_SetIP";
            this.btn_SetIP.Size = new System.Drawing.Size(111, 23);
            this.btn_SetIP.TabIndex = 27;
            this.btn_SetIP.Text = "SetIP";
            this.btn_SetIP.UseVisualStyleBackColor = true;
            this.btn_SetIP.Click += new System.EventHandler(this.btn_SetIP_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(12, 598);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(47, 12);
            this.label_Status.TabIndex = 23;
            this.label_Status.Text = "Status:";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(65, 595);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(293, 21);
            this.textBox_Status.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReadTriggerMode);
            this.groupBox3.Controls.Add(this.btn_SetTriggerMode);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_ReadTable);
            this.groupBox3.Controls.Add(this.btn_SetTable);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 186);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEQ Operation";
            // 
            // ReadTriggerMode
            // 
            this.ReadTriggerMode.Location = new System.Drawing.Point(223, 145);
            this.ReadTriggerMode.Name = "ReadTriggerMode";
            this.ReadTriggerMode.Size = new System.Drawing.Size(123, 23);
            this.ReadTriggerMode.TabIndex = 18;
            this.ReadTriggerMode.Text = "ReadTriggerMode";
            this.ReadTriggerMode.UseVisualStyleBackColor = true;
            this.ReadTriggerMode.Click += new System.EventHandler(this.ReadTriggerMode_Click);
            // 
            // btn_SetTriggerMode
            // 
            this.btn_SetTriggerMode.Location = new System.Drawing.Point(25, 146);
            this.btn_SetTriggerMode.Name = "btn_SetTriggerMode";
            this.btn_SetTriggerMode.Size = new System.Drawing.Size(124, 23);
            this.btn_SetTriggerMode.TabIndex = 17;
            this.btn_SetTriggerMode.Text = "SetTriggerMode";
            this.btn_SetTriggerMode.UseVisualStyleBackColor = true;
            this.btn_SetTriggerMode.Click += new System.EventHandler(this.btn_SetTriggerMode_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "ModuleIndex";
            // 
            // btn_ReadTable
            // 
            this.btn_ReadTable.Location = new System.Drawing.Point(222, 116);
            this.btn_ReadTable.Name = "btn_ReadTable";
            this.btn_ReadTable.Size = new System.Drawing.Size(124, 23);
            this.btn_ReadTable.TabIndex = 1;
            this.btn_ReadTable.Text = "ReadSEQTable";
            this.btn_ReadTable.UseVisualStyleBackColor = true;
            this.btn_ReadTable.Click += new System.EventHandler(this.btn_ReadTable_Click);
            // 
            // btn_SetTable
            // 
            this.btn_SetTable.Location = new System.Drawing.Point(25, 116);
            this.btn_SetTable.Name = "btn_SetTable";
            this.btn_SetTable.Size = new System.Drawing.Size(124, 23);
            this.btn_SetTable.TabIndex = 1;
            this.btn_SetTable.Text = "SetSEQTable";
            this.btn_SetTable.UseVisualStyleBackColor = true;
            this.btn_SetTable.Click += new System.EventHandler(this.btn_SetTable_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(119, 90);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 21);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_TriggerMode);
            this.groupBox4.Controls.Add(this.radioBtn_Programmable);
            this.groupBox4.Controls.Add(this.radioBtn_General);
            this.groupBox4.Location = new System.Drawing.Point(16, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 66);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Trigger Mode";
            // 
            // btn_TriggerMode
            // 
            this.btn_TriggerMode.Location = new System.Drawing.Point(207, 35);
            this.btn_TriggerMode.Name = "btn_TriggerMode";
            this.btn_TriggerMode.Size = new System.Drawing.Size(123, 23);
            this.btn_TriggerMode.TabIndex = 1;
            this.btn_TriggerMode.Text = "SetTriggerMode";
            this.btn_TriggerMode.UseVisualStyleBackColor = true;
            this.btn_TriggerMode.Click += new System.EventHandler(this.btn_TriggerMode_Click);
            // 
            // radioBtn_Programmable
            // 
            this.radioBtn_Programmable.AutoSize = true;
            this.radioBtn_Programmable.Location = new System.Drawing.Point(9, 42);
            this.radioBtn_Programmable.Name = "radioBtn_Programmable";
            this.radioBtn_Programmable.Size = new System.Drawing.Size(137, 16);
            this.radioBtn_Programmable.TabIndex = 0;
            this.radioBtn_Programmable.Text = "ProgrammableTrigger";
            this.radioBtn_Programmable.UseVisualStyleBackColor = true;
            // 
            // radioBtn_General
            // 
            this.radioBtn_General.AutoSize = true;
            this.radioBtn_General.Checked = true;
            this.radioBtn_General.Location = new System.Drawing.Point(9, 20);
            this.radioBtn_General.Name = "radioBtn_General";
            this.radioBtn_General.Size = new System.Drawing.Size(107, 16);
            this.radioBtn_General.TabIndex = 0;
            this.radioBtn_General.TabStop = true;
            this.radioBtn_General.Text = "GeneralTrigger";
            this.radioBtn_General.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "(Range:[1-4])";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SetSEQTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_SN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_COMName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_SerialPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ChannelIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_OpenChannel;
        private System.Windows.Forms.Button button_CloseChannel;
        private System.Windows.Forms.Button buttonSetIntensity;
        private System.Windows.Forms.TextBox textBox_Intensity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBtn_Programmable;
        private System.Windows.Forms.RadioButton radioBtn_General;
        private System.Windows.Forms.Button btn_ReadTable;
        private System.Windows.Forms.Button btn_SetTable;
        private System.Windows.Forms.Button btn_TriggerMode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ReadTriggerMode;
        private System.Windows.Forms.Button btn_SetTriggerMode;
        private System.Windows.Forms.Button btn_SetIP;
        private System.Windows.Forms.Button btn_SetCurrent;

    }
}

