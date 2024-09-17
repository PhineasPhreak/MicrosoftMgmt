using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MicrosoftMgmt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Variables Globals...
        public string System_OSversion = Environment.OSVersion.ToString();
        public string System_UserName = Environment.UserName.ToString();
        public string System_MachineName = Environment.MachineName.ToString();
        public string? System_Bit_Text;

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Environment.Is64BitOperatingSystem == true)
            {
                System_Bit_Text = "64-Bit";
            }
            else
            {
                System_Bit_Text = "i386";
            }

            // MainForm text window
            this.Text = "Microsoft Management .MSC Files in Windows at " + System_MachineName;

            // toolStripStatusLabel - Text
            toolStripStatusLabel1.Text = "User: " + System_UserName + ", " + "Host Os Version: " + System_OSversion + ", " + System_Bit_Text;
        }

        static void ProcessStandard(string cmd)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = cmd;

            Process processStart = new Process();

            //Setting up the Process Name here which we are
            // going to start from ProcessStartInfo
            processStart.StartInfo = startinfo;

            //Calling the Start Method of Process class to
            // Invoke our Process viz 'cmd.exe'
            processStart.Start();
            processStart.WaitForExit();
        }

        static void Process_MSC(string nameMSC)
        {
            //Setting an instance of ProcessStartInfo class
            // under System.Diagnostic Assembly Reference
            ProcessStartInfo startinfo = new ProcessStartInfo();

            //Setting the FileName to be Started like in our
            //Project we are just going to start a CMD Window.
            startinfo.FileName = "cmd.exe";
            //startinfo.UseShellExecute = false;
            startinfo.CreateNoWindow = true;

            // Run a specific command
            startinfo.Arguments = "/C " + nameMSC;

            //Setting up the Working Directory
            //startinfo.WorkingDirectory = @"C:\";

            //Instead of using the above two line of codes, You
            // can just use the code below:
            // ProcessStartInfo pro = new ProcessStartInfo("cmd.exe");
            //Creating an Instance of the Process Class
            // which will help to execute our Process
            Process processStart = new Process();

            //Setting up the Process Name here which we are
            // going to start from ProcessStartInfo
            processStart.StartInfo = startinfo;

            //Calling the Start Method of Process class to
            // Invoke our Process viz 'cmd.exe'
            processStart.Start();
            processStart.WaitForExit();
        }

        private void linkLabel_azman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process_MSC("azman.msc");
        }

        //
        // MenuStrip - Fichier
        //

        private void consoleWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStandard("cmd.exe");
        }

        private void powershellWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStandard("powershell.exe");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Docs :
            // Open Form2 from Form1, close Form1 from Form2
            // https://stackoverflow.com/questions/2958912/open-form2-from-form1-close-form1-from-form2
            //
            // How to set position second form depend on first form?
            // https://stackoverflow.com/questions/31492787/how-to-set-position-second-form-depend-on-first-form

            About frm_About = new About(this);
            frm_About.StartPosition = FormStartPosition.CenterParent;
            frm_About.ShowDialog();

            //frm_About.StartPosition = FormStartPosition.Manual;
            //frm_About.Load += delegate (object s2, EventArgs e2)
            //{
            //    frm_About.Location = new Point(this.Bounds.Location.X + this.Bounds.Width / 2 - frm_About.Width / 2, this.Bounds.Location.Y + this.Bounds.Height / 2 - frm_About.Height / 2);
            //};
            //frm_About.Show();
        }
    }
}
