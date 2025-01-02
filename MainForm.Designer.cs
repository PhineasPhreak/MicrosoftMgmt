namespace MicrosoftMgmt
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip_Info = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage_Windows = new TabPage();
            groupBox_Windows = new GroupBox();
            tableLayoutPanel_Windows = new TableLayoutPanel();
            label_MSCFile = new Label();
            label_ConsoleName = new Label();
            label_Details = new Label();
            linkLabel_azman = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            linkLabel1_certlm = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            linkLabel1_certmgr = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
            linkLabel1_comexp = new LinkLabel();
            label7 = new Label();
            label8 = new Label();
            linkLabel1_compmgmt = new LinkLabel();
            label9 = new Label();
            label10 = new Label();
            linkLabel1_devmgmt = new LinkLabel();
            label11 = new Label();
            label12 = new Label();
            linkLabel1_devmoderunasuserconfig = new LinkLabel();
            label13 = new Label();
            label14 = new Label();
            linkLabel1_diskmgmt = new LinkLabel();
            label15 = new Label();
            label16 = new Label();
            linkLabel1_eventvwr = new LinkLabel();
            label17 = new Label();
            label18 = new Label();
            linkLabel1_fsmgmt = new LinkLabel();
            label19 = new Label();
            label20 = new Label();
            linkLabel1_gpedit = new LinkLabel();
            label21 = new Label();
            label22 = new Label();
            linkLabel1_lusrmgr = new LinkLabel();
            label23 = new Label();
            label24 = new Label();
            linkLabel1_perfmon = new LinkLabel();
            label25 = new Label();
            label26 = new Label();
            linkLabel1_printmanagement = new LinkLabel();
            label27 = new Label();
            label28 = new Label();
            linkLabel1_rsop = new LinkLabel();
            label29 = new Label();
            label30 = new Label();
            linkLabel1_secpol = new LinkLabel();
            label31 = new Label();
            label32 = new Label();
            linkLabel1_services = new LinkLabel();
            label33 = new Label();
            label34 = new Label();
            linkLabel1_taskschd = new LinkLabel();
            label35 = new Label();
            label36 = new Label();
            linkLabel1_tpm = new LinkLabel();
            label37 = new Label();
            label38 = new Label();
            linkLabel1_wf = new LinkLabel();
            label39 = new Label();
            label40 = new Label();
            linkLabel1_wmimgmt = new LinkLabel();
            label41 = new Label();
            label42 = new Label();
            tabPage_WindowsServer = new TabPage();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            consoleWindowsToolStripMenuItem = new ToolStripMenuItem();
            powershellWindowsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            editionToolStripMenuItem = new ToolStripMenuItem();
            outilsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            afficherLaideToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            groupBox_WindowsServer = new GroupBox();
            statusStrip_Info.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_Windows.SuspendLayout();
            groupBox_Windows.SuspendLayout();
            tableLayoutPanel_Windows.SuspendLayout();
            tabPage_WindowsServer.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip_Info
            // 
            statusStrip_Info.ImageScalingSize = new Size(20, 20);
            statusStrip_Info.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip_Info.Location = new Point(0, 777);
            statusStrip_Info.Name = "statusStrip_Info";
            statusStrip_Info.Size = new Size(932, 26);
            statusStrip_Info.TabIndex = 0;
            statusStrip_Info.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(176, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel_Text";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_Windows);
            tabControl1.Controls.Add(tabPage_WindowsServer);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(932, 749);
            tabControl1.TabIndex = 1;
            // 
            // tabPage_Windows
            // 
            tabPage_Windows.Controls.Add(groupBox_Windows);
            tabPage_Windows.Location = new Point(4, 29);
            tabPage_Windows.Name = "tabPage_Windows";
            tabPage_Windows.Padding = new Padding(3);
            tabPage_Windows.Size = new Size(924, 716);
            tabPage_Windows.TabIndex = 0;
            tabPage_Windows.Text = "Windows 11";
            tabPage_Windows.UseVisualStyleBackColor = true;
            // 
            // groupBox_Windows
            // 
            groupBox_Windows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Windows.Controls.Add(tableLayoutPanel_Windows);
            groupBox_Windows.Location = new Point(8, 6);
            groupBox_Windows.Name = "groupBox_Windows";
            groupBox_Windows.Size = new Size(908, 707);
            groupBox_Windows.TabIndex = 1;
            groupBox_Windows.TabStop = false;
            groupBox_Windows.Text = "List of All MSC Files in Windows";
            // 
            // tableLayoutPanel_Windows
            // 
            tableLayoutPanel_Windows.ColumnCount = 3;
            tableLayoutPanel_Windows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.1138515F));
            tableLayoutPanel_Windows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1004753F));
            tableLayoutPanel_Windows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.785675F));
            tableLayoutPanel_Windows.Controls.Add(label_MSCFile, 0, 0);
            tableLayoutPanel_Windows.Controls.Add(label_ConsoleName, 1, 0);
            tableLayoutPanel_Windows.Controls.Add(label_Details, 2, 0);
            tableLayoutPanel_Windows.Controls.Add(linkLabel_azman, 0, 1);
            tableLayoutPanel_Windows.Controls.Add(label1, 1, 1);
            tableLayoutPanel_Windows.Controls.Add(label2, 2, 1);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_certlm, 0, 2);
            tableLayoutPanel_Windows.Controls.Add(label3, 1, 2);
            tableLayoutPanel_Windows.Controls.Add(label4, 2, 2);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_certmgr, 0, 3);
            tableLayoutPanel_Windows.Controls.Add(label5, 1, 3);
            tableLayoutPanel_Windows.Controls.Add(label6, 2, 3);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_comexp, 0, 4);
            tableLayoutPanel_Windows.Controls.Add(label7, 1, 4);
            tableLayoutPanel_Windows.Controls.Add(label8, 2, 4);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_compmgmt, 0, 5);
            tableLayoutPanel_Windows.Controls.Add(label9, 1, 5);
            tableLayoutPanel_Windows.Controls.Add(label10, 2, 5);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_devmgmt, 0, 6);
            tableLayoutPanel_Windows.Controls.Add(label11, 1, 6);
            tableLayoutPanel_Windows.Controls.Add(label12, 2, 6);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_devmoderunasuserconfig, 0, 7);
            tableLayoutPanel_Windows.Controls.Add(label13, 1, 7);
            tableLayoutPanel_Windows.Controls.Add(label14, 2, 7);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_diskmgmt, 0, 8);
            tableLayoutPanel_Windows.Controls.Add(label15, 1, 8);
            tableLayoutPanel_Windows.Controls.Add(label16, 2, 8);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_eventvwr, 0, 9);
            tableLayoutPanel_Windows.Controls.Add(label17, 1, 9);
            tableLayoutPanel_Windows.Controls.Add(label18, 2, 9);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_fsmgmt, 0, 10);
            tableLayoutPanel_Windows.Controls.Add(label19, 1, 10);
            tableLayoutPanel_Windows.Controls.Add(label20, 2, 10);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_gpedit, 0, 11);
            tableLayoutPanel_Windows.Controls.Add(label21, 1, 11);
            tableLayoutPanel_Windows.Controls.Add(label22, 2, 11);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_lusrmgr, 0, 12);
            tableLayoutPanel_Windows.Controls.Add(label23, 1, 12);
            tableLayoutPanel_Windows.Controls.Add(label24, 2, 12);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_perfmon, 0, 13);
            tableLayoutPanel_Windows.Controls.Add(label25, 1, 13);
            tableLayoutPanel_Windows.Controls.Add(label26, 2, 13);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_printmanagement, 0, 14);
            tableLayoutPanel_Windows.Controls.Add(label27, 1, 14);
            tableLayoutPanel_Windows.Controls.Add(label28, 2, 14);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_rsop, 0, 15);
            tableLayoutPanel_Windows.Controls.Add(label29, 1, 15);
            tableLayoutPanel_Windows.Controls.Add(label30, 2, 15);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_secpol, 0, 16);
            tableLayoutPanel_Windows.Controls.Add(label31, 1, 16);
            tableLayoutPanel_Windows.Controls.Add(label32, 2, 16);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_services, 0, 17);
            tableLayoutPanel_Windows.Controls.Add(label33, 1, 17);
            tableLayoutPanel_Windows.Controls.Add(label34, 2, 17);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_taskschd, 0, 18);
            tableLayoutPanel_Windows.Controls.Add(label35, 1, 18);
            tableLayoutPanel_Windows.Controls.Add(label36, 2, 18);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_tpm, 0, 19);
            tableLayoutPanel_Windows.Controls.Add(label37, 1, 19);
            tableLayoutPanel_Windows.Controls.Add(label38, 2, 19);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_wf, 0, 20);
            tableLayoutPanel_Windows.Controls.Add(label39, 1, 20);
            tableLayoutPanel_Windows.Controls.Add(label40, 2, 20);
            tableLayoutPanel_Windows.Controls.Add(linkLabel1_wmimgmt, 0, 21);
            tableLayoutPanel_Windows.Controls.Add(label41, 1, 21);
            tableLayoutPanel_Windows.Controls.Add(label42, 2, 21);
            tableLayoutPanel_Windows.Dock = DockStyle.Fill;
            tableLayoutPanel_Windows.Location = new Point(3, 23);
            tableLayoutPanel_Windows.Name = "tableLayoutPanel_Windows";
            tableLayoutPanel_Windows.RowCount = 23;
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Windows.Size = new Size(902, 681);
            tableLayoutPanel_Windows.TabIndex = 0;
            // 
            // label_MSCFile
            // 
            label_MSCFile.AutoSize = true;
            label_MSCFile.Location = new Point(3, 0);
            label_MSCFile.Name = "label_MSCFile";
            label_MSCFile.Size = new Size(66, 20);
            label_MSCFile.TabIndex = 0;
            label_MSCFile.Text = "MSC File";
            // 
            // label_ConsoleName
            // 
            label_ConsoleName.AutoSize = true;
            label_ConsoleName.Location = new Point(238, 0);
            label_ConsoleName.Name = "label_ConsoleName";
            label_ConsoleName.Size = new Size(106, 20);
            label_ConsoleName.TabIndex = 1;
            label_ConsoleName.Text = "Console Name";
            // 
            // label_Details
            // 
            label_Details.AutoSize = true;
            label_Details.Location = new Point(527, 0);
            label_Details.Name = "label_Details";
            label_Details.Size = new Size(55, 20);
            label_Details.TabIndex = 2;
            label_Details.Text = "Details";
            // 
            // linkLabel_azman
            // 
            linkLabel_azman.AutoSize = true;
            linkLabel_azman.Location = new Point(3, 20);
            linkLabel_azman.Name = "linkLabel_azman";
            linkLabel_azman.Size = new Size(82, 20);
            linkLabel_azman.TabIndex = 3;
            linkLabel_azman.TabStop = true;
            linkLabel_azman.Text = "azman.msc";
            linkLabel_azman.LinkClicked += linkLabel_azman_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 20);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 4;
            label1.Text = "Authorization Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 20);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 5;
            label2.Text = "Manage Authorization Stores";
            // 
            // linkLabel1_certlm
            // 
            linkLabel1_certlm.AutoSize = true;
            linkLabel1_certlm.Location = new Point(3, 40);
            linkLabel1_certlm.Name = "linkLabel1_certlm";
            linkLabel1_certlm.Size = new Size(80, 20);
            linkLabel1_certlm.TabIndex = 6;
            linkLabel1_certlm.TabStop = true;
            linkLabel1_certlm.Text = "certlm.msc";
            linkLabel1_certlm.LinkClicked += linkLabel1_certlm_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 40);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 7;
            label3.Text = "Certificates Local Computer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 40);
            label4.Name = "label4";
            label4.Size = new Size(337, 20);
            label4.TabIndex = 8;
            label4.Text = "Loads the list of certificates of the local computer";
            // 
            // linkLabel1_certmgr
            // 
            linkLabel1_certmgr.AutoSize = true;
            linkLabel1_certmgr.Location = new Point(3, 60);
            linkLabel1_certmgr.Name = "linkLabel1_certmgr";
            linkLabel1_certmgr.Size = new Size(90, 20);
            linkLabel1_certmgr.TabIndex = 9;
            linkLabel1_certmgr.TabStop = true;
            linkLabel1_certmgr.Text = "certmgr.msc";
            linkLabel1_certmgr.LinkClicked += linkLabel1_certmgr_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 60);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 10;
            label5.Text = "Certificates";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 60);
            label6.Name = "label6";
            label6.Size = new Size(264, 20);
            label6.TabIndex = 11;
            label6.Text = "Loads the list of certificates of the user";
            // 
            // linkLabel1_comexp
            // 
            linkLabel1_comexp.AutoSize = true;
            linkLabel1_comexp.Location = new Point(3, 80);
            linkLabel1_comexp.Name = "linkLabel1_comexp";
            linkLabel1_comexp.Size = new Size(91, 20);
            linkLabel1_comexp.TabIndex = 12;
            linkLabel1_comexp.TabStop = true;
            linkLabel1_comexp.Text = "comexp.msc";
            linkLabel1_comexp.LinkClicked += linkLabel1_comexp_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 80);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 13;
            label7.Text = "Component Services";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(527, 80);
            label8.Name = "label8";
            label8.Size = new Size(368, 20);
            label8.TabIndex = 14;
            label8.Text = "Loads Component Services, Event Viewer, and Services";
            // 
            // linkLabel1_compmgmt
            // 
            linkLabel1_compmgmt.AutoSize = true;
            linkLabel1_compmgmt.Location = new Point(3, 100);
            linkLabel1_compmgmt.Name = "linkLabel1_compmgmt";
            linkLabel1_compmgmt.Size = new Size(116, 20);
            linkLabel1_compmgmt.TabIndex = 15;
            linkLabel1_compmgmt.TabStop = true;
            linkLabel1_compmgmt.Text = "compmgmt.msc";
            linkLabel1_compmgmt.LinkClicked += linkLabel1_compmgmt_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(238, 100);
            label9.Name = "label9";
            label9.Size = new Size(167, 20);
            label9.TabIndex = 16;
            label9.Text = "Computer Management";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(527, 100);
            label10.Name = "label10";
            label10.Size = new Size(362, 20);
            label10.TabIndex = 17;
            label10.Text = resources.GetString("label10.Text");
            // 
            // linkLabel1_devmgmt
            // 
            linkLabel1_devmgmt.AutoSize = true;
            linkLabel1_devmgmt.Location = new Point(3, 120);
            linkLabel1_devmgmt.Name = "linkLabel1_devmgmt";
            linkLabel1_devmgmt.Size = new Size(102, 20);
            linkLabel1_devmgmt.TabIndex = 18;
            linkLabel1_devmgmt.TabStop = true;
            linkLabel1_devmgmt.Text = "devmgmt.msc";
            linkLabel1_devmgmt.LinkClicked += linkLabel1_devmgmt_LinkClicked;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(238, 120);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 19;
            label11.Text = "Device Manager";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(527, 120);
            label12.Name = "label12";
            label12.Size = new Size(363, 20);
            label12.TabIndex = 20;
            label12.Text = "Opens the Device Manager to manage hardware and devices";
            // 
            // linkLabel1_devmoderunasuserconfig
            // 
            linkLabel1_devmoderunasuserconfig.AutoSize = true;
            linkLabel1_devmoderunasuserconfig.Location = new Point(3, 140);
            linkLabel1_devmoderunasuserconfig.Name = "linkLabel1_devmoderunasuserconfig";
            linkLabel1_devmoderunasuserconfig.Size = new Size(205, 20);
            linkLabel1_devmoderunasuserconfig.TabIndex = 21;
            linkLabel1_devmoderunasuserconfig.TabStop = true;
            linkLabel1_devmoderunasuserconfig.Text = "devmoderunasuserconfig.msc";
            linkLabel1_devmoderunasuserconfig.LinkClicked += linkLabel1_devmoderunasuserconfig_LinkClicked;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(238, 140);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 22;
            label13.Text = "---";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(527, 140);
            label14.Name = "label14";
            label14.Size = new Size(359, 20);
            label14.TabIndex = 23;
            label14.Text = "To manage the Start Menu, Taskbar, and Notification settings";
            // 
            // linkLabel1_diskmgmt
            // 
            linkLabel1_diskmgmt.AutoSize = true;
            linkLabel1_diskmgmt.Location = new Point(3, 160);
            linkLabel1_diskmgmt.Name = "linkLabel1_diskmgmt";
            linkLabel1_diskmgmt.Size = new Size(104, 20);
            linkLabel1_diskmgmt.TabIndex = 24;
            linkLabel1_diskmgmt.TabStop = true;
            linkLabel1_diskmgmt.Text = "diskmgmt.msc";
            linkLabel1_diskmgmt.LinkClicked += linkLabel1_diskmgmt_LinkClicked;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(238, 160);
            label15.Name = "label15";
            label15.Size = new Size(129, 20);
            label15.TabIndex = 25;
            label15.Text = "Disk Management";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(527, 160);
            label16.Name = "label16";
            label16.Size = new Size(357, 20);
            label16.TabIndex = 26;
            label16.Text = "Opens Disk Management to administrate connected storage devices";
            // 
            // linkLabel1_eventvwr
            // 
            linkLabel1_eventvwr.AutoSize = true;
            linkLabel1_eventvwr.Location = new Point(3, 180);
            linkLabel1_eventvwr.Name = "linkLabel1_eventvwr";
            linkLabel1_eventvwr.Size = new Size(97, 20);
            linkLabel1_eventvwr.TabIndex = 27;
            linkLabel1_eventvwr.TabStop = true;
            linkLabel1_eventvwr.Text = "eventvwr.msc";
            linkLabel1_eventvwr.LinkClicked += linkLabel1_eventvwr_LinkClicked;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(238, 180);
            label17.Name = "label17";
            label17.Size = new Size(94, 20);
            label17.TabIndex = 28;
            label17.Text = "Event Viewer";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(527, 180);
            label18.Name = "label18";
            label18.Size = new Size(362, 20);
            label18.TabIndex = 29;
            label18.Text = "Opens the Event Viewer which displays the operating system, software, and hardware events";
            // 
            // linkLabel1_fsmgmt
            // 
            linkLabel1_fsmgmt.AutoSize = true;
            linkLabel1_fsmgmt.Location = new Point(3, 200);
            linkLabel1_fsmgmt.Name = "linkLabel1_fsmgmt";
            linkLabel1_fsmgmt.Size = new Size(89, 20);
            linkLabel1_fsmgmt.TabIndex = 30;
            linkLabel1_fsmgmt.TabStop = true;
            linkLabel1_fsmgmt.Text = "fsmgmt.msc";
            linkLabel1_fsmgmt.LinkClicked += linkLabel1_fsmgmt_LinkClicked;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(238, 200);
            label19.Name = "label19";
            label19.Size = new Size(107, 20);
            label19.TabIndex = 31;
            label19.Text = "Shared Folders";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(527, 200);
            label20.Name = "label20";
            label20.Size = new Size(346, 20);
            label20.TabIndex = 32;
            label20.Text = "Loads the list of shared folders, sessions, and open files";
            // 
            // linkLabel1_gpedit
            // 
            linkLabel1_gpedit.AutoSize = true;
            linkLabel1_gpedit.Location = new Point(3, 220);
            linkLabel1_gpedit.Name = "linkLabel1_gpedit";
            linkLabel1_gpedit.Size = new Size(82, 20);
            linkLabel1_gpedit.TabIndex = 33;
            linkLabel1_gpedit.TabStop = true;
            linkLabel1_gpedit.Text = "gpedit.msc";
            linkLabel1_gpedit.LinkClicked += linkLabel1_gpedit_LinkClicked;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(238, 220);
            label21.Name = "label21";
            label21.Size = new Size(136, 20);
            label21.TabIndex = 34;
            label21.Text = "Group Policy Editor";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(527, 220);
            label22.Name = "label22";
            label22.Size = new Size(359, 20);
            label22.TabIndex = 35;
            label22.Text = "Loads Group Policy Editor to manage system policies";
            // 
            // linkLabel1_lusrmgr
            // 
            linkLabel1_lusrmgr.AutoSize = true;
            linkLabel1_lusrmgr.Location = new Point(3, 240);
            linkLabel1_lusrmgr.Name = "linkLabel1_lusrmgr";
            linkLabel1_lusrmgr.Size = new Size(88, 20);
            linkLabel1_lusrmgr.TabIndex = 36;
            linkLabel1_lusrmgr.TabStop = true;
            linkLabel1_lusrmgr.Text = "lusrmgr.msc";
            linkLabel1_lusrmgr.LinkClicked += linkLabel1_lusrmgr_LinkClicked;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(238, 240);
            label23.Name = "label23";
            label23.Size = new Size(163, 20);
            label23.TabIndex = 37;
            label23.Text = "Local Users and Groups";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(527, 240);
            label24.Name = "label24";
            label24.Size = new Size(326, 20);
            label24.TabIndex = 38;
            label24.Text = "Interface to manage local users and user groups";
            // 
            // linkLabel1_perfmon
            // 
            linkLabel1_perfmon.AutoSize = true;
            linkLabel1_perfmon.Location = new Point(3, 260);
            linkLabel1_perfmon.Name = "linkLabel1_perfmon";
            linkLabel1_perfmon.Size = new Size(95, 20);
            linkLabel1_perfmon.TabIndex = 39;
            linkLabel1_perfmon.TabStop = true;
            linkLabel1_perfmon.Text = "perfmon.msc";
            linkLabel1_perfmon.LinkClicked += linkLabel1_perfmon_LinkClicked;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(238, 260);
            label25.Name = "label25";
            label25.Size = new Size(149, 20);
            label25.TabIndex = 40;
            label25.Text = "Performance Monitor";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(527, 260);
            label26.Name = "label26";
            label26.Size = new Size(257, 20);
            label26.TabIndex = 41;
            label26.Text = "Loads Windows Performance Monitor";
            // 
            // linkLabel1_printmanagement
            // 
            linkLabel1_printmanagement.AutoSize = true;
            linkLabel1_printmanagement.Location = new Point(3, 280);
            linkLabel1_printmanagement.Name = "linkLabel1_printmanagement";
            linkLabel1_printmanagement.Size = new Size(157, 20);
            linkLabel1_printmanagement.TabIndex = 42;
            linkLabel1_printmanagement.TabStop = true;
            linkLabel1_printmanagement.Text = "printmanagement.msc";
            linkLabel1_printmanagement.LinkClicked += linkLabel1_printmanagement_LinkClicked;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(238, 280);
            label27.Name = "label27";
            label27.Size = new Size(131, 20);
            label27.TabIndex = 43;
            label27.Text = "Print Management";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(527, 280);
            label28.Name = "label28";
            label28.Size = new Size(117, 20);
            label28.TabIndex = 44;
            label28.Text = "Manage printers";
            // 
            // linkLabel1_rsop
            // 
            linkLabel1_rsop.AutoSize = true;
            linkLabel1_rsop.Location = new Point(3, 300);
            linkLabel1_rsop.Name = "linkLabel1_rsop";
            linkLabel1_rsop.Size = new Size(67, 20);
            linkLabel1_rsop.TabIndex = 45;
            linkLabel1_rsop.TabStop = true;
            linkLabel1_rsop.Text = "rsop.msc";
            linkLabel1_rsop.LinkClicked += linkLabel1_rsop_LinkClicked;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(238, 300);
            label29.Name = "label29";
            label29.Size = new Size(166, 20);
            label29.TabIndex = 46;
            label29.Text = "Resultant Set of Policies";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(527, 300);
            label30.Name = "label30";
            label30.Size = new Size(316, 20);
            label30.TabIndex = 47;
            label30.Text = "List policies, full results only available through command-line tool gpresult";
            // 
            // linkLabel1_secpol
            // 
            linkLabel1_secpol.AutoSize = true;
            linkLabel1_secpol.Location = new Point(3, 320);
            linkLabel1_secpol.Name = "linkLabel1_secpol";
            linkLabel1_secpol.Size = new Size(81, 20);
            linkLabel1_secpol.TabIndex = 48;
            linkLabel1_secpol.TabStop = true;
            linkLabel1_secpol.Text = "secpol.msc";
            linkLabel1_secpol.LinkClicked += linkLabel1_secpol_LinkClicked;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(238, 320);
            label31.Name = "label31";
            label31.Size = new Size(142, 20);
            label31.TabIndex = 49;
            label31.Text = "Local Security Policy";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(527, 320);
            label32.Name = "label32";
            label32.Size = new Size(343, 20);
            label32.TabIndex = 50;
            label32.Text = "Loads policies such as account policies, public key policies, or advanced audit policy configuration";
            // 
            // linkLabel1_services
            // 
            linkLabel1_services.AutoSize = true;
            linkLabel1_services.Location = new Point(3, 340);
            linkLabel1_services.Name = "linkLabel1_services";
            linkLabel1_services.Size = new Size(89, 20);
            linkLabel1_services.TabIndex = 51;
            linkLabel1_services.TabStop = true;
            linkLabel1_services.Text = "services.msc";
            linkLabel1_services.LinkClicked += linkLabel1_services_LinkClicked;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(238, 340);
            label33.Name = "label33";
            label33.Size = new Size(125, 20);
            label33.TabIndex = 52;
            label33.Text = "Services Manager";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(527, 340);
            label34.Name = "label34";
            label34.Size = new Size(346, 20);
            label34.TabIndex = 53;
            label34.Text = "Loads the list of installed services to manage them.";
            // 
            // linkLabel1_taskschd
            // 
            linkLabel1_taskschd.AutoSize = true;
            linkLabel1_taskschd.Location = new Point(3, 360);
            linkLabel1_taskschd.Name = "linkLabel1_taskschd";
            linkLabel1_taskschd.Size = new Size(94, 20);
            linkLabel1_taskschd.TabIndex = 54;
            linkLabel1_taskschd.TabStop = true;
            linkLabel1_taskschd.Text = "taskschd.msc";
            linkLabel1_taskschd.LinkClicked += linkLabel1_taskschd_LinkClicked;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(238, 360);
            label35.Name = "label35";
            label35.Size = new Size(105, 20);
            label35.TabIndex = 55;
            label35.Text = "Task Scheduler";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(527, 360);
            label36.Name = "label36";
            label36.Size = new Size(285, 20);
            label36.TabIndex = 56;
            label36.Text = "Loads the Task Scheduler to manage tasks";
            // 
            // linkLabel1_tpm
            // 
            linkLabel1_tpm.AutoSize = true;
            linkLabel1_tpm.Location = new Point(3, 380);
            linkLabel1_tpm.Name = "linkLabel1_tpm";
            linkLabel1_tpm.Size = new Size(65, 20);
            linkLabel1_tpm.TabIndex = 57;
            linkLabel1_tpm.TabStop = true;
            linkLabel1_tpm.Text = "tpm.msc";
            linkLabel1_tpm.LinkClicked += linkLabel1_tpm_LinkClicked;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(238, 380);
            label37.Name = "label37";
            label37.Size = new Size(265, 20);
            label37.TabIndex = 58;
            label37.Text = "Trusted Platform Module Management";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(527, 380);
            label38.Name = "label38";
            label38.Size = new Size(253, 20);
            label38.TabIndex = 59;
            label38.Text = "Manage the TPM on the local device.";
            // 
            // linkLabel1_wf
            // 
            linkLabel1_wf.AutoSize = true;
            linkLabel1_wf.Location = new Point(3, 400);
            linkLabel1_wf.Name = "linkLabel1_wf";
            linkLabel1_wf.Size = new Size(54, 20);
            linkLabel1_wf.TabIndex = 60;
            linkLabel1_wf.TabStop = true;
            linkLabel1_wf.Text = "wf.msc";
            linkLabel1_wf.LinkClicked += linkLabel1_wf_LinkClicked;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(238, 400);
            label39.Name = "label39";
            label39.Size = new Size(125, 20);
            label39.TabIndex = 61;
            label39.Text = "Windows Firewall";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(527, 400);
            label40.Name = "label40";
            label40.Size = new Size(324, 20);
            label40.TabIndex = 62;
            label40.Text = "Starts Windows Firewall with Advanced Security";
            // 
            // linkLabel1_wmimgmt
            // 
            linkLabel1_wmimgmt.AutoSize = true;
            linkLabel1_wmimgmt.Location = new Point(3, 420);
            linkLabel1_wmimgmt.Name = "linkLabel1_wmimgmt";
            linkLabel1_wmimgmt.Size = new Size(106, 20);
            linkLabel1_wmimgmt.TabIndex = 63;
            linkLabel1_wmimgmt.TabStop = true;
            linkLabel1_wmimgmt.Text = "wmimgmt.msc";
            linkLabel1_wmimgmt.LinkClicked += linkLabel1_wmimgmt_LinkClicked;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(238, 420);
            label41.Name = "label41";
            label41.Size = new Size(132, 20);
            label41.TabIndex = 64;
            label41.Text = "WMI Management";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(527, 420);
            label42.Name = "label42";
            label42.Size = new Size(342, 20);
            label42.TabIndex = 65;
            label42.Text = "Configure and Control the Windows Management Instrumentation Service";
            // 
            // tabPage_WindowsServer
            // 
            tabPage_WindowsServer.Controls.Add(groupBox_WindowsServer);
            tabPage_WindowsServer.Location = new Point(4, 29);
            tabPage_WindowsServer.Name = "tabPage_WindowsServer";
            tabPage_WindowsServer.Padding = new Padding(3);
            tabPage_WindowsServer.Size = new Size(924, 716);
            tabPage_WindowsServer.TabIndex = 1;
            tabPage_WindowsServer.Text = "Windows Server 2016/2019/2022";
            tabPage_WindowsServer.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editionToolStripMenuItem, outilsToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(932, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consoleWindowsToolStripMenuItem, powershellWindowsToolStripMenuItem, toolStripSeparator2, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // consoleWindowsToolStripMenuItem
            // 
            consoleWindowsToolStripMenuItem.Image = Properties.Resources.Console;
            consoleWindowsToolStripMenuItem.Name = "consoleWindowsToolStripMenuItem";
            consoleWindowsToolStripMenuItem.Size = new Size(227, 26);
            consoleWindowsToolStripMenuItem.Text = "Console Windows";
            consoleWindowsToolStripMenuItem.Click += consoleWindowsToolStripMenuItem_Click;
            // 
            // powershellWindowsToolStripMenuItem
            // 
            powershellWindowsToolStripMenuItem.Image = Properties.Resources.PowerShellInteractiveWindow;
            powershellWindowsToolStripMenuItem.Name = "powershellWindowsToolStripMenuItem";
            powershellWindowsToolStripMenuItem.Size = new Size(227, 26);
            powershellWindowsToolStripMenuItem.Text = "Powershell Windows";
            powershellWindowsToolStripMenuItem.Click += powershellWindowsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(224, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            quitterToolStripMenuItem.Size = new Size(227, 26);
            quitterToolStripMenuItem.Text = "&Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // editionToolStripMenuItem
            // 
            editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            editionToolStripMenuItem.Size = new Size(70, 24);
            editionToolStripMenuItem.Text = "&Edition";
            // 
            // outilsToolStripMenuItem
            // 
            outilsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            outilsToolStripMenuItem.Size = new Size(61, 24);
            outilsToolStripMenuItem.Text = "&Outils";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Image = Properties.Resources.Settings;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(153, 26);
            optionsToolStripMenuItem.Text = "&Options...";
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afficherLaideToolStripMenuItem, toolStripSeparator1, aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(54, 24);
            aideToolStripMenuItem.Text = "&Aide";
            // 
            // afficherLaideToolStripMenuItem
            // 
            afficherLaideToolStripMenuItem.Image = Properties.Resources.F1Help;
            afficherLaideToolStripMenuItem.Name = "afficherLaideToolStripMenuItem";
            afficherLaideToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            afficherLaideToolStripMenuItem.Size = new Size(241, 26);
            afficherLaideToolStripMenuItem.Text = "Afficher l'aide";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(238, 6);
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Image = Properties.Resources.StatusInformation;
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(241, 26);
            aProposToolStripMenuItem.Text = "A Propos...";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // groupBox_WindowsServer
            // 
            groupBox_WindowsServer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_WindowsServer.Location = new Point(8, 6);
            groupBox_WindowsServer.Name = "groupBox_WindowsServer";
            groupBox_WindowsServer.Size = new Size(908, 704);
            groupBox_WindowsServer.TabIndex = 0;
            groupBox_WindowsServer.TabStop = false;
            groupBox_WindowsServer.Text = "List of All MSC Files in Servers";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 803);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip_Info);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            statusStrip_Info.ResumeLayout(false);
            statusStrip_Info.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage_Windows.ResumeLayout(false);
            groupBox_Windows.ResumeLayout(false);
            tableLayoutPanel_Windows.ResumeLayout(false);
            tableLayoutPanel_Windows.PerformLayout();
            tabPage_WindowsServer.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip_Info;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabPage_Windows;
        private TabPage tabPage_WindowsServer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem editionToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem afficherLaideToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem outilsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel_Windows;
        private GroupBox groupBox_Windows;
        private Label label_MSCFile;
        private Label label_ConsoleName;
        private Label label_Details;
        private LinkLabel linkLabel_azman;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem consoleWindowsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem powershellWindowsToolStripMenuItem;
        private LinkLabel linkLabel1_certlm;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1_certmgr;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1_comexp;
        private Label label7;
        private Label label8;
        private LinkLabel linkLabel1_compmgmt;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabel1_devmgmt;
        private Label label11;
        private Label label12;
        private LinkLabel linkLabel1_devmoderunasuserconfig;
        private Label label13;
        private Label label14;
        private LinkLabel linkLabel1_diskmgmt;
        private Label label15;
        private Label label16;
        private LinkLabel linkLabel1_eventvwr;
        private Label label17;
        private Label label18;
        private LinkLabel linkLabel1_fsmgmt;
        private Label label19;
        private Label label20;
        private LinkLabel linkLabel1_gpedit;
        private Label label21;
        private Label label22;
        private LinkLabel linkLabel1_lusrmgr;
        private Label label23;
        private Label label24;
        private LinkLabel linkLabel1_perfmon;
        private Label label25;
        private Label label26;
        private LinkLabel linkLabel1_printmanagement;
        private Label label27;
        private Label label28;
        private LinkLabel linkLabel1_rsop;
        private Label label29;
        private Label label30;
        private LinkLabel linkLabel1_secpol;
        private Label label31;
        private Label label32;
        private LinkLabel linkLabel1_services;
        private Label label33;
        private Label label34;
        private LinkLabel linkLabel1_taskschd;
        private Label label35;
        private Label label36;
        private LinkLabel linkLabel1_tpm;
        private Label label37;
        private Label label38;
        private LinkLabel linkLabel1_wf;
        private Label label39;
        private Label label40;
        private LinkLabel linkLabel1_wmimgmt;
        private Label label41;
        private Label label42;
        private GroupBox groupBox_WindowsServer;
    }
}
