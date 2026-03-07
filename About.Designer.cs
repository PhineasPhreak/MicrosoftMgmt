namespace MicrosoftMgmt
{
    partial class About
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
            button_OK = new Button();
            pictureBox1 = new PictureBox();
            groupBox_MoreInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_OK
            // 
            button_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_OK.Location = new Point(590, 307);
            button_OK.Margin = new Padding(3, 2, 3, 2);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(82, 22);
            button_OK.TabIndex = 0;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.info_icon_48;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox_MoreInfo
            // 
            groupBox_MoreInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_MoreInfo.Location = new Point(66, 11);
            groupBox_MoreInfo.Margin = new Padding(3, 2, 3, 2);
            groupBox_MoreInfo.Name = "groupBox_MoreInfo";
            groupBox_MoreInfo.Padding = new Padding(3, 2, 3, 2);
            groupBox_MoreInfo.Size = new Size(608, 152);
            groupBox_MoreInfo.TabIndex = 0;
            groupBox_MoreInfo.TabStop = false;
            groupBox_MoreInfo.Text = "Informations Additionnel";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(groupBox_MoreInfo);
            Controls.Add(pictureBox1);
            Controls.Add(button_OK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "A Propos...";
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_OK;
        private PictureBox pictureBox1;
        private GroupBox groupBox_MoreInfo;
    }
}