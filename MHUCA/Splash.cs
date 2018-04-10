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
    public partial class Splash : Form
    {
        //Timer variable
        public int countDown { get; set; }

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //initializer/method call
            countDown = 9;
            timer1.Start();
        }

        //splash screen method
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            if (countDown > 0)
            {
                countDown = countDown - 1;
            }
            else
            {
                timer1.Stop();
                new FrmMainPage().Show();
                this.Hide();
            }
        }
    }
}
