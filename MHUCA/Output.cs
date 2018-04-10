using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHUCA
{
    public partial class FrmOutput : Form
    {
        public FrmOutput()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Restart query call.
            new FrmMainPage().Show();
            this.Hide();
            Focus();

        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            //Show Report Page
            new FrmReport().Show();
            this.Hide();
            Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit App
            Application.Exit();
        }

    }
}
