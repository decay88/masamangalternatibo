﻿namespace masamangalternatibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formpanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radRTLO = new System.Windows.Forms.RadioButton();
            this.radOverflow = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAdminFlag = new System.Windows.Forms.CheckBox();
            this.pnlFileOptGroup = new System.Windows.Forms.Panel();
            this.chkHidWin = new System.Windows.Forms.CheckBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.chkArguments = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStreamConsole = new System.Windows.Forms.CheckBox();
            this.chkConsole = new System.Windows.Forms.CheckBox();
            this.chkTarExe = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drpDrives = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lblPayload = new System.Windows.Forms.Label();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpoof = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDbg = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConsole = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.dbgRtb = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Label();
            this.titlebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdPayload = new System.Windows.Forms.OpenFileDialog();
            this.ofdSpoof = new System.Windows.Forms.OpenFileDialog();
            this.ofdIcon = new System.Windows.Forms.OpenFileDialog();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnExtract = new System.Windows.Forms.LinkLabel();
            this.btnClearImage = new System.Windows.Forms.LinkLabel();
            this.btnBrowseImage = new System.Windows.Forms.LinkLabel();
            this.imgFileIcon = new System.Windows.Forms.PictureBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btn_RefreshDrives = new System.Windows.Forms.Button();
            this.btnBrowsePayload = new System.Windows.Forms.Button();
            this.btnBrowseSpoof = new System.Windows.Forms.Button();
            this.btnMiniPad = new System.Windows.Forms.Label();
            this.btn3rdParty = new System.Windows.Forms.Label();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.formpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlFileOptGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // formpanel
            // 
            this.formpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.formpanel.Controls.Add(this.groupBox2);
            this.formpanel.Controls.Add(this.groupBox3);
            this.formpanel.Controls.Add(this.groupBox1);
            this.formpanel.Controls.Add(this.panel2);
            this.formpanel.Controls.Add(this.groupBox5);
            this.formpanel.Location = new System.Drawing.Point(1, 25);
            this.formpanel.Name = "formpanel";
            this.formpanel.Size = new System.Drawing.Size(552, 297);
            this.formpanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbArguments);
            this.groupBox2.Controls.Add(this.btnExtract);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.btnClearImage);
            this.groupBox2.Controls.Add(this.btnBrowseImage);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chkAdminFlag);
            this.groupBox2.Controls.Add(this.pnlFileOptGroup);
            this.groupBox2.Controls.Add(this.imgFileIcon);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 164);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(225, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 111);
            this.panel3.TabIndex = 27;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radRTLO);
            this.groupBox6.Controls.Add(this.radOverflow);
            this.groupBox6.Controls.Add(this.radNone);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(8, 122);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(296, 35);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File Name Spoofing";
            // 
            // radRTLO
            // 
            this.radRTLO.AutoSize = true;
            this.radRTLO.Location = new System.Drawing.Point(142, 13);
            this.radRTLO.Name = "radRTLO";
            this.radRTLO.Size = new System.Drawing.Size(134, 17);
            this.radRTLO.TabIndex = 2;
            this.radRTLO.Text = "Right to left Override";
            this.tooltip.SetToolTip(this.radRTLO, "Use the Right to left Override character to reverse a fake extension and the\r\nrea" +
        "l extension.");
            this.radRTLO.UseVisualStyleBackColor = true;
            // 
            // radOverflow
            // 
            this.radOverflow.AutoSize = true;
            this.radOverflow.Location = new System.Drawing.Point(64, 13);
            this.radOverflow.Name = "radOverflow";
            this.radOverflow.Size = new System.Drawing.Size(72, 17);
            this.radOverflow.TabIndex = 1;
            this.radOverflow.Text = "Overflow";
            this.tooltip.SetToolTip(this.radOverflow, "Overflow the file name with invisible characters between the file name\r\nand exten" +
        "sion");
            this.radOverflow.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Location = new System.Drawing.Point(5, 13);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(53, 17);
            this.radNone.TabIndex = 0;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.tooltip.SetToolTip(this.radNone, "No file spoofing");
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Icon";
            // 
            // chkAdminFlag
            // 
            this.chkAdminFlag.AutoSize = true;
            this.chkAdminFlag.Location = new System.Drawing.Point(8, 106);
            this.chkAdminFlag.Name = "chkAdminFlag";
            this.chkAdminFlag.Size = new System.Drawing.Size(84, 17);
            this.chkAdminFlag.TabIndex = 11;
            this.chkAdminFlag.Text = "Admin Flag";
            this.tooltip.SetToolTip(this.chkAdminFlag, "Flag the executable to require Administrative priviledges");
            this.chkAdminFlag.UseVisualStyleBackColor = true;
            // 
            // pnlFileOptGroup
            // 
            this.pnlFileOptGroup.Controls.Add(this.chkHidWin);
            this.pnlFileOptGroup.Controls.Add(this.btnCommand);
            this.pnlFileOptGroup.Controls.Add(this.chkArguments);
            this.pnlFileOptGroup.Controls.Add(this.label5);
            this.pnlFileOptGroup.Controls.Add(this.chkStreamConsole);
            this.pnlFileOptGroup.Controls.Add(this.chkConsole);
            this.pnlFileOptGroup.Controls.Add(this.chkTarExe);
            this.pnlFileOptGroup.Location = new System.Drawing.Point(5, 13);
            this.pnlFileOptGroup.Name = "pnlFileOptGroup";
            this.pnlFileOptGroup.Size = new System.Drawing.Size(216, 98);
            this.pnlFileOptGroup.TabIndex = 19;
            // 
            // chkHidWin
            // 
            this.chkHidWin.AutoSize = true;
            this.chkHidWin.Checked = true;
            this.chkHidWin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHidWin.Location = new System.Drawing.Point(3, 80);
            this.chkHidWin.Name = "chkHidWin";
            this.chkHidWin.Size = new System.Drawing.Size(111, 17);
            this.chkHidWin.TabIndex = 16;
            this.chkHidWin.Text = "Hidden Window";
            this.tooltip.SetToolTip(this.chkHidWin, "Flags the payload to execute as a hidden program");
            this.chkHidWin.UseVisualStyleBackColor = true;
            // 
            // btnCommand
            // 
            this.btnCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnCommand.Enabled = false;
            this.btnCommand.FlatAppearance.BorderSize = 0;
            this.btnCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommand.Location = new System.Drawing.Point(176, 27);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(25, 22);
            this.btnCommand.TabIndex = 15;
            this.btnCommand.Text = "/c";
            this.tooltip.SetToolTip(this.btnCommand, "Change the command execution switch");
            this.btnCommand.UseVisualStyleBackColor = false;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // chkArguments
            // 
            this.chkArguments.AutoSize = true;
            this.chkArguments.Location = new System.Drawing.Point(3, 5);
            this.chkArguments.Name = "chkArguments";
            this.chkArguments.Size = new System.Drawing.Size(85, 17);
            this.chkArguments.TabIndex = 15;
            this.chkArguments.Text = "Arguments:";
            this.tooltip.SetToolTip(this.chkArguments, "Enable the payload executable to receive arguments pre-execution");
            this.chkArguments.UseVisualStyleBackColor = true;
            this.chkArguments.CheckedChanged += new System.EventHandler(this.chkArguments_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "└";
            // 
            // chkStreamConsole
            // 
            this.chkStreamConsole.AutoSize = true;
            this.chkStreamConsole.Enabled = false;
            this.chkStreamConsole.Location = new System.Drawing.Point(20, 48);
            this.chkStreamConsole.Name = "chkStreamConsole";
            this.chkStreamConsole.Size = new System.Drawing.Size(198, 17);
            this.chkStreamConsole.TabIndex = 8;
            this.chkStreamConsole.Text = "Stream console output to text file";
            this.tooltip.SetToolTip(this.chkStreamConsole, "An alternative dumping/logging option;Stream the console\r\noutput (stdout) to a te" +
        "xt file\r\n\r\nExecutes as: cmd [opt] [payload] > %random%.madmp");
            this.chkStreamConsole.UseVisualStyleBackColor = true;
            // 
            // chkConsole
            // 
            this.chkConsole.AutoSize = true;
            this.chkConsole.Location = new System.Drawing.Point(3, 31);
            this.chkConsole.Name = "chkConsole";
            this.chkConsole.Size = new System.Drawing.Size(173, 17);
            this.chkConsole.TabIndex = 7;
            this.chkConsole.Text = "Execute in Command Prompt";
            this.tooltip.SetToolTip(this.chkConsole, "Execute the payload through the command line / prompt\r\n\r\nExecutes as: cmd [opt] [" +
        "payload]");
            this.chkConsole.UseVisualStyleBackColor = true;
            this.chkConsole.CheckedChanged += new System.EventHandler(this.chkConsole_CheckedChanged);
            // 
            // chkTarExe
            // 
            this.chkTarExe.AutoSize = true;
            this.chkTarExe.Location = new System.Drawing.Point(3, 67);
            this.chkTarExe.Name = "chkTarExe";
            this.chkTarExe.Size = new System.Drawing.Size(193, 17);
            this.chkTarExe.TabIndex = 10;
            this.chkTarExe.Text = "Execute payload in Targets\' Drive";
            this.tooltip.SetToolTip(this.chkTarExe, "Extracts the payload to the Targets\' drive\r\nand executes it there\r\n* Payload is d" +
        "ropped in the temporary folder");
            this.chkTarExe.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWrite);
            this.groupBox3.Controls.Add(this.btnBuild);
            this.groupBox3.Controls.Add(this.btn_RefreshDrives);
            this.groupBox3.Controls.Add(this.drpDrives);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(11, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 40);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // drpDrives
            // 
            this.drpDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDrives.FormattingEnabled = true;
            this.drpDrives.Location = new System.Drawing.Point(80, 12);
            this.drpDrives.Name = "drpDrives";
            this.drpDrives.Size = new System.Drawing.Size(68, 21);
            this.drpDrives.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Drive:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSwitchMode);
            this.groupBox1.Controls.Add(this.lblPayload);
            this.groupBox1.Controls.Add(this.tbPayload);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSpoof);
            this.groupBox1.Controls.Add(this.btnBrowsePayload);
            this.groupBox1.Controls.Add(this.btnBrowseSpoof);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 73);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnSwitchMode.FlatAppearance.BorderSize = 0;
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.Location = new System.Drawing.Point(243, 15);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(25, 22);
            this.btnSwitchMode.TabIndex = 14;
            this.btnSwitchMode.Text = "F";
            this.tooltip.SetToolTip(this.btnSwitchMode, resources.GetString("btnSwitchMode.ToolTip"));
            this.btnSwitchMode.UseVisualStyleBackColor = false;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // lblPayload
            // 
            this.lblPayload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayload.AutoSize = true;
            this.lblPayload.Location = new System.Drawing.Point(6, 18);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(71, 13);
            this.lblPayload.TabIndex = 0;
            this.lblPayload.Text = "Payload File:";
            this.lblPayload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(82, 15);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(155, 22);
            this.tbPayload.TabIndex = 1;
            this.tooltip.SetToolTip(this.tbPayload, "Payload input.\r\nNote: Payloads are always executed with a hidden flag");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spoofed File:";
            // 
            // tbSpoof
            // 
            this.tbSpoof.Location = new System.Drawing.Point(82, 43);
            this.tbSpoof.Name = "tbSpoof";
            this.tbSpoof.Size = new System.Drawing.Size(186, 22);
            this.tbSpoof.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.btnMiniPad);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.btn3rdParty);
            this.panel2.Controls.Add(this.lblDbg);
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 18);
            this.panel2.TabIndex = 6;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(507, 2);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "versionlabel";
            this.tooltip.SetToolTip(this.lblVersion, "Version of the software");
            // 
            // lblDbg
            // 
            this.lblDbg.AutoSize = true;
            this.lblDbg.Location = new System.Drawing.Point(7, 2);
            this.lblDbg.Name = "lblDbg";
            this.lblDbg.Size = new System.Drawing.Size(66, 13);
            this.lblDbg.TabIndex = 17;
            this.lblDbg.Text = "debuglabel";
            this.tooltip.SetToolTip(this.lblDbg, "Debug label");
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnConsole);
            this.groupBox5.Controls.Add(this.tbConsole);
            this.groupBox5.Controls.Add(this.dbgRtb);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(324, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 270);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Console";
            // 
            // btnConsole
            // 
            this.btnConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnConsole.FlatAppearance.BorderSize = 0;
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.Location = new System.Drawing.Point(192, 244);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(25, 22);
            this.btnConsole.TabIndex = 15;
            this.btnConsole.Text = ">";
            this.btnConsole.UseVisualStyleBackColor = false;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.Location = new System.Drawing.Point(3, 244);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(186, 22);
            this.tbConsole.TabIndex = 19;
            // 
            // dbgRtb
            // 
            this.dbgRtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dbgRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbgRtb.DetectUrls = false;
            this.dbgRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgRtb.ForeColor = System.Drawing.Color.White;
            this.dbgRtb.Location = new System.Drawing.Point(3, 18);
            this.dbgRtb.Name = "dbgRtb";
            this.dbgRtb.ReadOnly = true;
            this.dbgRtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dbgRtb.Size = new System.Drawing.Size(215, 249);
            this.dbgRtb.TabIndex = 18;
            this.dbgRtb.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(531, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 13);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "❌";
            this.tooltip.SetToolTip(this.btnClose, "Exit mA");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // titlebar
            // 
            this.titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlebar.Controls.Add(this.label1);
            this.titlebar.Controls.Add(this.btnClose);
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(554, 25);
            this.titlebar.TabIndex = 1;
            this.titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "masamangAlternatibo";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // ofdPayload
            // 
            this.ofdPayload.Filter = "All Files (*.*)|*.*";
            this.ofdPayload.Title = "Payload File";
            this.ofdPayload.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdPayload_FileOk);
            // 
            // ofdSpoof
            // 
            this.ofdSpoof.Filter = "All Files (*.*)|*.*";
            this.ofdSpoof.Title = "Spoofed File";
            this.ofdSpoof.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSpoof_FileOk);
            // 
            // ofdIcon
            // 
            this.ofdIcon.Filter = "Icon Files (*.ico)|*.ico";
            this.ofdIcon.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdIcon_FileOk);
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 150;
            this.tooltip.ReshowDelay = 100;
            // 
            // btnExtract
            // 
            this.btnExtract.ActiveLinkColor = System.Drawing.Color.White;
            this.btnExtract.AutoSize = true;
            this.btnExtract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Image = global::masamangalternatibo.Properties.Resources.signright16;
            this.btnExtract.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnExtract.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnExtract.Location = new System.Drawing.Point(278, 96);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(19, 15);
            this.btnExtract.TabIndex = 28;
            this.btnExtract.TabStop = true;
            this.btnExtract.Text = "    ";
            this.tooltip.SetToolTip(this.btnExtract, "Extract the icon of the current spoofed file");
            this.btnExtract.VisitedLinkColor = System.Drawing.Color.White;
            this.btnExtract.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnExtract_LinkClicked);
            // 
            // btnClearImage
            // 
            this.btnClearImage.ActiveLinkColor = System.Drawing.Color.White;
            this.btnClearImage.AutoSize = true;
            this.btnClearImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearImage.Image = global::masamangalternatibo.Properties.Resources.delete16;
            this.btnClearImage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnClearImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnClearImage.Location = new System.Drawing.Point(235, 96);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(19, 15);
            this.btnClearImage.TabIndex = 26;
            this.btnClearImage.TabStop = true;
            this.btnClearImage.Text = "    ";
            this.tooltip.SetToolTip(this.btnClearImage, "Use the default icon");
            this.btnClearImage.VisitedLinkColor = System.Drawing.Color.White;
            this.btnClearImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClearImage_LinkClicked);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.ActiveLinkColor = System.Drawing.Color.White;
            this.btnBrowseImage.AutoSize = true;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.Image = global::masamangalternatibo.Properties.Resources.folder16;
            this.btnBrowseImage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnBrowseImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(257, 96);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(19, 15);
            this.btnBrowseImage.TabIndex = 25;
            this.btnBrowseImage.TabStop = true;
            this.btnBrowseImage.Text = "    ";
            this.tooltip.SetToolTip(this.btnBrowseImage, "Use a custom icon");
            this.btnBrowseImage.VisitedLinkColor = System.Drawing.Color.White;
            this.btnBrowseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnBrowseImage_LinkClicked);
            // 
            // imgFileIcon
            // 
            this.imgFileIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgFileIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFileIcon.Location = new System.Drawing.Point(235, 34);
            this.imgFileIcon.Name = "imgFileIcon";
            this.imgFileIcon.Size = new System.Drawing.Size(60, 60);
            this.imgFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFileIcon.TabIndex = 10;
            this.imgFileIcon.TabStop = false;
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Transparent;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Image = global::masamangalternatibo.Properties.Resources.pencil16;
            this.btnWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWrite.Location = new System.Drawing.Point(181, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(61, 22);
            this.btnWrite.TabIndex = 17;
            this.btnWrite.Text = "Write";
            this.btnWrite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.btnWrite, "Generate the script and opens the editor for manual editing of the script before " +
        "compilation.\r\n(Script will appear in MiniPad)");
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.FlatAppearance.BorderSize = 0;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.Image = global::masamangalternatibo.Properties.Resources.build16;
            this.btnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuild.Location = new System.Drawing.Point(243, 12);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(61, 22);
            this.btnBuild.TabIndex = 14;
            this.btnBuild.Text = "Build";
            this.btnBuild.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.btnBuild, "Build the payload");
            this.btnBuild.UseVisualStyleBackColor = false;
            // 
            // btn_RefreshDrives
            // 
            this.btn_RefreshDrives.BackColor = System.Drawing.Color.Transparent;
            this.btn_RefreshDrives.FlatAppearance.BorderSize = 0;
            this.btn_RefreshDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RefreshDrives.Image = global::masamangalternatibo.Properties.Resources.sync16;
            this.btn_RefreshDrives.Location = new System.Drawing.Point(151, 11);
            this.btn_RefreshDrives.Name = "btn_RefreshDrives";
            this.btn_RefreshDrives.Size = new System.Drawing.Size(26, 22);
            this.btn_RefreshDrives.TabIndex = 16;
            this.tooltip.SetToolTip(this.btn_RefreshDrives, "Rescan for drives");
            this.btn_RefreshDrives.UseVisualStyleBackColor = false;
            this.btn_RefreshDrives.Click += new System.EventHandler(this.btnRefreshDrives_Click);
            // 
            // btnBrowsePayload
            // 
            this.btnBrowsePayload.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowsePayload.FlatAppearance.BorderSize = 0;
            this.btnBrowsePayload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePayload.Image = global::masamangalternatibo.Properties.Resources.folder16;
            this.btnBrowsePayload.Location = new System.Drawing.Point(269, 14);
            this.btnBrowsePayload.Name = "btnBrowsePayload";
            this.btnBrowsePayload.Size = new System.Drawing.Size(25, 22);
            this.btnBrowsePayload.TabIndex = 4;
            this.tooltip.SetToolTip(this.btnBrowsePayload, "Browse a payload executable to use");
            this.btnBrowsePayload.UseVisualStyleBackColor = false;
            this.btnBrowsePayload.Click += new System.EventHandler(this.btnBrowsePayload_Click);
            // 
            // btnBrowseSpoof
            // 
            this.btnBrowseSpoof.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSpoof.FlatAppearance.BorderSize = 0;
            this.btnBrowseSpoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSpoof.Image = global::masamangalternatibo.Properties.Resources.folder16;
            this.btnBrowseSpoof.Location = new System.Drawing.Point(269, 42);
            this.btnBrowseSpoof.Name = "btnBrowseSpoof";
            this.btnBrowseSpoof.Size = new System.Drawing.Size(25, 22);
            this.btnBrowseSpoof.TabIndex = 5;
            this.tooltip.SetToolTip(this.btnBrowseSpoof, "Browse a file for the payload to spoof as\r\nNote: Spoof file will be executed rega" +
        "rdless of format");
            this.btnBrowseSpoof.UseVisualStyleBackColor = false;
            this.btnBrowseSpoof.Click += new System.EventHandler(this.btnBrowseSpoof_Click);
            // 
            // btnMiniPad
            // 
            this.btnMiniPad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniPad.AutoSize = true;
            this.btnMiniPad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiniPad.Image = global::masamangalternatibo.Properties.Resources.notepad16;
            this.btnMiniPad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiniPad.Location = new System.Drawing.Point(377, 2);
            this.btnMiniPad.Name = "btnMiniPad";
            this.btnMiniPad.Size = new System.Drawing.Size(67, 13);
            this.btnMiniPad.TabIndex = 22;
            this.btnMiniPad.Text = "      MiniPad";
            this.btnMiniPad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.btnMiniPad, "Open a Miniature Notepad for quick editing and display/editing of pre-compiled pa" +
        "yload code.");
            this.btnMiniPad.Click += new System.EventHandler(this.btnMiniPad_Click);
            // 
            // btn3rdParty
            // 
            this.btn3rdParty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3rdParty.AutoSize = true;
            this.btn3rdParty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3rdParty.Image = global::masamangalternatibo.Properties.Resources.heart16;
            this.btn3rdParty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3rdParty.Location = new System.Drawing.Point(444, 2);
            this.btn3rdParty.Name = "btn3rdParty";
            this.btn3rdParty.Size = new System.Drawing.Size(57, 13);
            this.btn3rdParty.TabIndex = 21;
            this.btn3rdParty.Text = "      About";
            this.btn3rdParty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.btn3rdParty, "Open the about form");
            this.btn3rdParty.Click += new System.EventHandler(this.btn3rdParty_Click);
            // 
            // tbArguments
            // 
            this.tbArguments.Enabled = false;
            this.tbArguments.Location = new System.Drawing.Point(90, 15);
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(119, 22);
            this.tbArguments.TabIndex = 29;
            this.tooltip.SetToolTip(this.tbArguments, resources.GetString("tbArguments.ToolTip"));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(554, 323);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.formpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "masamangAlternatibo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pnlFileOptGroup.ResumeLayout(false);
            this.pnlFileOptGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formpanel;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpoof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPayload;
        private System.Windows.Forms.Label lblPayload;
        private System.Windows.Forms.Button btnBrowsePayload;
        private System.Windows.Forms.Button btnBrowseSpoof;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkConsole;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStreamConsole;
        private System.Windows.Forms.PictureBox imgFileIcon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTarExe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDbg;
        private System.Windows.Forms.CheckBox chkAdminFlag;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.RichTextBox dbgRtb;
        private System.Windows.Forms.OpenFileDialog ofdPayload;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.ComboBox drpDrives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RefreshDrives;
        private System.Windows.Forms.CheckBox chkArguments;
        private System.Windows.Forms.Panel pnlFileOptGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radRTLO;
        private System.Windows.Forms.RadioButton radOverflow;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.OpenFileDialog ofdSpoof;
        private System.Windows.Forms.Label btn3rdParty;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.OpenFileDialog ofdIcon;
        private System.Windows.Forms.LinkLabel btnClearImage;
        private System.Windows.Forms.LinkLabel btnBrowseImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.LinkLabel btnExtract;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label btnMiniPad;
        private System.Windows.Forms.CheckBox chkHidWin;
        private System.Windows.Forms.TextBox tbArguments;
    }
}

