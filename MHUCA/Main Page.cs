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
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //Start a new query selection
            new FrmQuery().Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Move to report
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
