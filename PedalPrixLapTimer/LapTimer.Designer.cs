namespace PedalPrixLapTimer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPageTimer = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxNextRider = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonAddAsNext = new System.Windows.Forms.Button();
            this.textBoxCurrentRider = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRiderLaps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRaceTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalLaps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPitTime = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxLapTime = new System.Windows.Forms.TextBox();
            this.buttonPitOut = new System.Windows.Forms.Button();
            this.buttonPitIn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLap = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.tabPageSignIn = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRiderName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.tabSerial = new System.Windows.Forms.TabControl();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.textBoxInternet = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.buttonSerialDisconnect = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelTrigger = new System.Windows.Forms.Label();
            this.textBoxTriggerCode = new System.Windows.Forms.TextBox();
            this.textBoxEchoCode = new System.Windows.Forms.TextBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelEcho = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.serialConnect = new System.Windows.Forms.Button();
            this.tabPageTimer.SuspendLayout();
            this.tabPageSignIn.SuspendLayout();
            this.tabSerial.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            this.tabPageSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPageTimer
            // 
            this.tabPageTimer.Controls.Add(this.label7);
            this.tabPageTimer.Controls.Add(this.comboBoxNextRider);
            this.tabPageTimer.Controls.Add(this.listView1);
            this.tabPageTimer.Controls.Add(this.buttonAddAsNext);
            this.tabPageTimer.Controls.Add(this.textBoxCurrentRider);
            this.tabPageTimer.Controls.Add(this.label6);
            this.tabPageTimer.Controls.Add(this.buttonAddComment);
            this.tabPageTimer.Controls.Add(this.textBoxComment);
            this.tabPageTimer.Controls.Add(this.label5);
            this.tabPageTimer.Controls.Add(this.textBoxRiderLaps);
            this.tabPageTimer.Controls.Add(this.label4);
            this.tabPageTimer.Controls.Add(this.textBoxRaceTime);
            this.tabPageTimer.Controls.Add(this.label3);
            this.tabPageTimer.Controls.Add(this.textBoxTotalLaps);
            this.tabPageTimer.Controls.Add(this.label2);
            this.tabPageTimer.Controls.Add(this.label1);
            this.tabPageTimer.Controls.Add(this.textBoxPitTime);
            this.tabPageTimer.Controls.Add(this.richTextBox1);
            this.tabPageTimer.Controls.Add(this.textBoxLapTime);
            this.tabPageTimer.Controls.Add(this.buttonPitOut);
            this.tabPageTimer.Controls.Add(this.buttonPitIn);
            this.tabPageTimer.Controls.Add(this.buttonSave);
            this.tabPageTimer.Controls.Add(this.buttonClear);
            this.tabPageTimer.Controls.Add(this.buttonLap);
            this.tabPageTimer.Controls.Add(this.button_Reset);
            this.tabPageTimer.Controls.Add(this.button_Pause);
            this.tabPageTimer.Controls.Add(this.button_Start);
            this.tabPageTimer.Location = new System.Drawing.Point(4, 22);
            this.tabPageTimer.Name = "tabPageTimer";
            this.tabPageTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimer.Size = new System.Drawing.Size(1342, 582);
            this.tabPageTimer.TabIndex = 1;
            this.tabPageTimer.Text = "Timer";
            this.tabPageTimer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1141, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 140;
            this.label7.Text = "Next Rider Select";
            // 
            // comboBoxNextRider
            // 
            this.comboBoxNextRider.FormattingEnabled = true;
            this.comboBoxNextRider.Location = new System.Drawing.Point(1144, 22);
            this.comboBoxNextRider.Name = "comboBoxNextRider";
            this.comboBoxNextRider.Size = new System.Drawing.Size(100, 21);
            this.comboBoxNextRider.TabIndex = 139;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listView1.Location = new System.Drawing.Point(949, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 480);
            this.listView1.TabIndex = 138;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddAsNext
            // 
            this.buttonAddAsNext.Location = new System.Drawing.Point(1144, 49);
            this.buttonAddAsNext.Name = "buttonAddAsNext";
            this.buttonAddAsNext.Size = new System.Drawing.Size(100, 23);
            this.buttonAddAsNext.TabIndex = 137;
            this.buttonAddAsNext.Text = "Add As Next";
            this.buttonAddAsNext.UseVisualStyleBackColor = true;
            this.buttonAddAsNext.Click += new System.EventHandler(this.buttonAddAsNext_Click);
            // 
            // textBoxCurrentRider
            // 
            this.textBoxCurrentRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentRider.Location = new System.Drawing.Point(937, 22);
            this.textBoxCurrentRider.Name = "textBoxCurrentRider";
            this.textBoxCurrentRider.Size = new System.Drawing.Size(100, 32);
            this.textBoxCurrentRider.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1040, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Pit Time";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(858, 96);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(85, 23);
            this.buttonAddComment.TabIndex = 134;
            this.buttonAddComment.Text = "Add Comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(309, 96);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(543, 20);
            this.textBoxComment.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1040, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "Current Rider Laps";
            // 
            // textBoxRiderLaps
            // 
            this.textBoxRiderLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxRiderLaps.Location = new System.Drawing.Point(1043, 22);
            this.textBoxRiderLaps.Name = "textBoxRiderLaps";
            this.textBoxRiderLaps.Size = new System.Drawing.Size(92, 32);
            this.textBoxRiderLaps.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 130;
            this.label4.Text = "Total Time";
            // 
            // textBoxRaceTime
            // 
            this.textBoxRaceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRaceTime.Location = new System.Drawing.Point(309, 22);
            this.textBoxRaceTime.Name = "textBoxRaceTime";
            this.textBoxRaceTime.Size = new System.Drawing.Size(510, 68);
            this.textBoxRaceTime.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Total Laps";
            // 
            // textBoxTotalLaps
            // 
            this.textBoxTotalLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalLaps.Location = new System.Drawing.Point(825, 22);
            this.textBoxTotalLaps.Name = "textBoxTotalLaps";
            this.textBoxTotalLaps.Size = new System.Drawing.Size(106, 68);
            this.textBoxTotalLaps.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(934, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Current Rider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Current Lap Time";
            // 
            // textBoxPitTime
            // 
            this.textBoxPitTime.Location = new System.Drawing.Point(1043, 70);
            this.textBoxPitTime.Name = "textBoxPitTime";
            this.textBoxPitTime.Size = new System.Drawing.Size(92, 20);
            this.textBoxPitTime.TabIndex = 124;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.richTextBox1.Location = new System.Drawing.Point(309, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(634, 454);
            this.richTextBox1.TabIndex = 123;
            this.richTextBox1.Text = "";
            // 
            // textBoxLapTime
            // 
            this.textBoxLapTime.Location = new System.Drawing.Point(937, 70);
            this.textBoxLapTime.Name = "textBoxLapTime";
            this.textBoxLapTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxLapTime.TabIndex = 122;
            // 
            // buttonPitOut
            // 
            this.buttonPitOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Italic);
            this.buttonPitOut.Location = new System.Drawing.Point(3, 219);
            this.buttonPitOut.Name = "buttonPitOut";
            this.buttonPitOut.Size = new System.Drawing.Size(300, 40);
            this.buttonPitOut.TabIndex = 121;
            this.buttonPitOut.Text = "PIT OUT";
            this.buttonPitOut.UseVisualStyleBackColor = true;
            this.buttonPitOut.Click += new System.EventHandler(this.buttonPitOut_Click);
            // 
            // buttonPitIn
            // 
            this.buttonPitIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.buttonPitIn.Location = new System.Drawing.Point(3, 173);
            this.buttonPitIn.Name = "buttonPitIn";
            this.buttonPitIn.Size = new System.Drawing.Size(300, 40);
            this.buttonPitIn.TabIndex = 120;
            this.buttonPitIn.Text = "PIT IN";
            this.buttonPitIn.UseVisualStyleBackColor = true;
            this.buttonPitIn.Click += new System.EventHandler(this.buttonPitIn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(6, 301);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(297, 30);
            this.buttonSave.TabIndex = 119;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(6, 265);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 30);
            this.buttonClear.TabIndex = 118;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLap
            // 
            this.buttonLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic);
            this.buttonLap.Location = new System.Drawing.Point(3, 67);
            this.buttonLap.Name = "buttonLap";
            this.buttonLap.Size = new System.Drawing.Size(300, 100);
            this.buttonLap.TabIndex = 117;
            this.buttonLap.Text = "LAP";
            this.buttonLap.UseVisualStyleBackColor = true;
            this.buttonLap.Click += new System.EventHandler(this.buttonLap_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(107, 265);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(95, 30);
            this.button_Reset.TabIndex = 116;
            this.button_Reset.Text = "RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pause.Location = new System.Drawing.Point(208, 265);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(95, 30);
            this.button_Pause.TabIndex = 115;
            this.button_Pause.Text = "PAUSE";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.button_Start.Location = new System.Drawing.Point(3, 6);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(300, 55);
            this.button_Start.TabIndex = 114;
            this.button_Start.Text = "START";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // tabPageSignIn
            // 
            this.tabPageSignIn.Controls.Add(this.label9);
            this.tabPageSignIn.Controls.Add(this.textBoxRiderName);
            this.tabPageSignIn.Controls.Add(this.label8);
            this.tabPageSignIn.Controls.Add(this.buttonSignIn);
            this.tabPageSignIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageSignIn.Name = "tabPageSignIn";
            this.tabPageSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignIn.Size = new System.Drawing.Size(1342, 582);
            this.tabPageSignIn.TabIndex = 0;
            this.tabPageSignIn.Text = "Sign In";
            this.tabPageSignIn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Please Type Your First And Last Name In The Box Below, Then Click Sign In.";
            // 
            // textBoxRiderName
            // 
            this.textBoxRiderName.Location = new System.Drawing.Point(12, 57);
            this.textBoxRiderName.Name = "textBoxRiderName";
            this.textBoxRiderName.Size = new System.Drawing.Size(400, 20);
            this.textBoxRiderName.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 34);
            this.label8.TabIndex = 92;
            this.label8.Text = "Rider Sign In";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(12, 83);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(400, 49);
            this.buttonSignIn.TabIndex = 91;
            this.buttonSignIn.Text = "SIGN IN";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // tabSerial
            // 
            this.tabSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSerial.Controls.Add(this.tabPageSignIn);
            this.tabSerial.Controls.Add(this.tabPageTimer);
            this.tabSerial.Controls.Add(this.tabPageBrowser);
            this.tabSerial.Controls.Add(this.tabPageSerial);
            this.tabSerial.Location = new System.Drawing.Point(12, 0);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.SelectedIndex = 0;
            this.tabSerial.Size = new System.Drawing.Size(1350, 608);
            this.tabSerial.TabIndex = 83;
            // 
            // tabPageBrowser
            // 
            this.tabPageBrowser.Controls.Add(this.textBoxInternet);
            this.tabPageBrowser.Controls.Add(this.buttonGo);
            this.tabPageBrowser.Controls.Add(this.webBrowser1);
            this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrowser.Name = "tabPageBrowser";
            this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrowser.Size = new System.Drawing.Size(1342, 582);
            this.tabPageBrowser.TabIndex = 2;
            this.tabPageBrowser.Text = "Browser";
            this.tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // textBoxInternet
            // 
            this.textBoxInternet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInternet.Location = new System.Drawing.Point(47, 7);
            this.textBoxInternet.Name = "textBoxInternet";
            this.textBoxInternet.Size = new System.Drawing.Size(1289, 20);
            this.textBoxInternet.TabIndex = 2;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(7, 7);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(34, 20);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1342, 549);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com.au", System.UriKind.Absolute);
            // 
            // tabPageSerial
            // 
            this.tabPageSerial.Controls.Add(this.buttonSerialDisconnect);
            this.tabPageSerial.Controls.Add(this.comboBoxBaudRate);
            this.tabPageSerial.Controls.Add(this.labelTrigger);
            this.tabPageSerial.Controls.Add(this.textBoxTriggerCode);
            this.tabPageSerial.Controls.Add(this.textBoxEchoCode);
            this.tabPageSerial.Controls.Add(this.labelBaud);
            this.tabPageSerial.Controls.Add(this.labelEcho);
            this.tabPageSerial.Controls.Add(this.labelComPort);
            this.tabPageSerial.Controls.Add(this.comboBoxComPort);
            this.tabPageSerial.Controls.Add(this.serialConnect);
            this.tabPageSerial.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerial.Name = "tabPageSerial";
            this.tabPageSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerial.Size = new System.Drawing.Size(1342, 582);
            this.tabPageSerial.TabIndex = 3;
            this.tabPageSerial.Text = "Serial Settings";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // buttonSerialDisconnect
            // 
            this.buttonSerialDisconnect.Location = new System.Drawing.Point(87, 6);
            this.buttonSerialDisconnect.Name = "buttonSerialDisconnect";
            this.buttonSerialDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialDisconnect.TabIndex = 11;
            this.buttonSerialDisconnect.Text = "Disconnect";
            this.buttonSerialDisconnect.UseVisualStyleBackColor = true;
            this.buttonSerialDisconnect.Click += new System.EventHandler(this.buttonSerialDisconnect_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(101, 99);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 10;
            this.comboBoxBaudRate.Text = "9600";
            // 
            // labelTrigger
            // 
            this.labelTrigger.AutoSize = true;
            this.labelTrigger.Location = new System.Drawing.Point(27, 154);
            this.labelTrigger.Name = "labelTrigger";
            this.labelTrigger.Size = new System.Drawing.Size(68, 13);
            this.labelTrigger.TabIndex = 9;
            this.labelTrigger.Text = "Trigger Code";
            // 
            // textBoxTriggerCode
            // 
            this.textBoxTriggerCode.Location = new System.Drawing.Point(101, 151);
            this.textBoxTriggerCode.Name = "textBoxTriggerCode";
            this.textBoxTriggerCode.Size = new System.Drawing.Size(121, 20);
            this.textBoxTriggerCode.TabIndex = 8;
            this.textBoxTriggerCode.Text = "trigger";
            // 
            // textBoxEchoCode
            // 
            this.textBoxEchoCode.Location = new System.Drawing.Point(101, 125);
            this.textBoxEchoCode.Name = "textBoxEchoCode";
            this.textBoxEchoCode.Size = new System.Drawing.Size(121, 20);
            this.textBoxEchoCode.TabIndex = 7;
            this.textBoxEchoCode.Text = "echo";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(27, 102);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(58, 13);
            this.labelBaud.TabIndex = 6;
            this.labelBaud.Text = "Baud Rate";
            // 
            // labelEcho
            // 
            this.labelEcho.AutoSize = true;
            this.labelEcho.Location = new System.Drawing.Point(27, 128);
            this.labelEcho.Name = "labelEcho";
            this.labelEcho.Size = new System.Drawing.Size(60, 13);
            this.labelEcho.TabIndex = 4;
            this.labelEcho.Text = "Echo Code";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(27, 75);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(50, 13);
            this.labelComPort.TabIndex = 2;
            this.labelComPort.Text = "Com Port";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(101, 72);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 1;
            this.comboBoxComPort.Text = "COM3";
            this.comboBoxComPort.DropDown += new System.EventHandler(this.comboBoxComPort_DropDown);
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(6, 6);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(75, 23);
            this.serialConnect.TabIndex = 0;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 620);
            this.Controls.Add(this.tabSerial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageTimer.ResumeLayout(false);
            this.tabPageTimer.PerformLayout();
            this.tabPageSignIn.ResumeLayout(false);
            this.tabPageSignIn.PerformLayout();
            this.tabSerial.ResumeLayout(false);
            this.tabPageBrowser.ResumeLayout(false);
            this.tabPageBrowser.PerformLayout();
            this.tabPageSerial.ResumeLayout(false);
            this.tabPageSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPageTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNextRider;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAddAsNext;
        private System.Windows.Forms.TextBox textBoxCurrentRider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRiderLaps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRaceTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalLaps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPitTime;
        private System.Windows.Forms.TextBox textBoxLapTime;
        private System.Windows.Forms.Button buttonPitOut;
        private System.Windows.Forms.Button buttonPitIn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLap;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TabPage tabPageSignIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRiderName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.TabControl tabSerial;
        private System.Windows.Forms.TabPage tabPageBrowser;
        private System.Windows.Forms.TextBox textBoxInternet;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPageSerial;
        private System.Windows.Forms.Button serialConnect;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelEcho;
        private System.Windows.Forms.Label labelTrigger;
        private System.Windows.Forms.TextBox textBoxTriggerCode;
        private System.Windows.Forms.TextBox textBoxEchoCode;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonSerialDisconnect;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}