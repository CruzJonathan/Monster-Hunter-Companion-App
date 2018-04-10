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
    public partial class FrmQuery : Form
    {  
        

        public FrmQuery()
        {
            InitializeComponent();
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //check to see if at least 1 item is chosen
            if (CmbMonster.SelectedItem != null || CmbWeapon.SelectedItem != null || CmbArmor.SelectedItem != null || CmbItems.SelectedItem != null || cmbCharms.SelectedItem != null || CmbMap.SelectedItem != null)
            {

                //Open Selection window
                new FrmSelection(CmbMonster.SelectedItem, CmbWeapon.SelectedItem, CmbArmor.SelectedItem, CmbItems.SelectedItem, cmbCharms.SelectedItem, CmbMap.SelectedItem).Show();
                this.Hide();
                Focus();
            }
            else
            {
                //error box displays
                MessageBox.Show("Please at least select one choice.");
            }
            
        }

    }
}
