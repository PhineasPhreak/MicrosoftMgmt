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
            statusStrip_Info.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_Windows.SuspendLayout();
            groupBox_Windows.SuspendLayout();
            tableLayoutPanel_Windows.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip_Info
            // 
            statusStrip_Info.ImageScalingSize = new Size(20, 20);
            statusStrip_Info.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip_Info.Location = new Point(0, 777);
            statusStrip_Info.Name = "statusStrip_Info";
            statusStrip_Info.Size = new Size(832, 26);
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
            tabControl1.Size = new Size(832, 749);
            tabControl1.TabIndex = 1;
            // 
            // tabPage_Windows
            // 
            tabPage_Windows.Controls.Add(groupBox_Windows);
            tabPage_Windows.Location = new Point(4, 29);
            tabPage_Windows.Name = "tabPage_Windows";
            tabPage_Windows.Padding = new Padding(3);
            tabPage_Windows.Size = new Size(824, 716);
            tabPage_Windows.TabIndex = 0;
            tabPage_Windows.Text = "Windows 10/11";
            tabPage_Windows.UseVisualStyleBackColor = true;
            // 
            // groupBox_Windows
            // 
            groupBox_Windows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Windows.Controls.Add(tableLayoutPanel_Windows);
            groupBox_Windows.Location = new Point(8, 6);
            groupBox_Windows.Name = "groupBox_Windows";
            groupBox_Windows.Size = new Size(808, 707);
            groupBox_Windows.TabIndex = 1;
            groupBox_Windows.TabStop = false;
            groupBox_Windows.Text = "List of All MSC Files in Windows";
            // 
            // tableLayoutPanel_Windows
            // 
            tableLayoutPanel_Windows.ColumnCount = 3;
            tableLayoutPanel_Windows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel_Windows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel_Windows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel_Windows.Controls.Add(label_MSCFile, 0, 0);
            tableLayoutPanel_Windows.Controls.Add(label_ConsoleName, 1, 0);
            tableLayoutPanel_Windows.Controls.Add(label_Details, 2, 0);
            tableLayoutPanel_Windows.Controls.Add(linkLabel_azman, 0, 1);
            tableLayoutPanel_Windows.Controls.Add(label1, 1, 1);
            tableLayoutPanel_Windows.Controls.Add(label2, 2, 1);
            tableLayoutPanel_Windows.Dock = DockStyle.Fill;
            tableLayoutPanel_Windows.Location = new Point(3, 23);
            tableLayoutPanel_Windows.Name = "tableLayoutPanel_Windows";
            tableLayoutPanel_Windows.RowCount = 22;
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
            tableLayoutPanel_Windows.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Windows.Size = new Size(802, 681);
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
            label_ConsoleName.Location = new Point(270, 0);
            label_ConsoleName.Name = "label_ConsoleName";
            label_ConsoleName.Size = new Size(106, 20);
            label_ConsoleName.TabIndex = 1;
            label_ConsoleName.Text = "Console Name";
            // 
            // label_Details
            // 
            label_Details.AutoSize = true;
            label_Details.Location = new Point(537, 0);
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
            label1.Location = new Point(270, 20);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 4;
            label1.Text = "Authorization Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 20);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 5;
            label2.Text = "Manage Authorization Stores";
            // 
            // tabPage_WindowsServer
            // 
            tabPage_WindowsServer.Location = new Point(4, 29);
            tabPage_WindowsServer.Name = "tabPage_WindowsServer";
            tabPage_WindowsServer.Padding = new Padding(3);
            tabPage_WindowsServer.Size = new Size(824, 716);
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
            menuStrip1.Size = new Size(832, 28);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 803);
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
    }
}
