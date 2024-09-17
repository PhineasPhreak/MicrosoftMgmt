using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftMgmt
{
    public partial class About : Form
    {
        Form opener;
        public About(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Fermer l'application entiere
            //opener.Close();

            this.Close();
        }
    }
}
