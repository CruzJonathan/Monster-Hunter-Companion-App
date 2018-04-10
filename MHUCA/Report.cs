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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Restart Query
            new FrmQuery().Show();
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
