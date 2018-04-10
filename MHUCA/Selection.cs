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
    public partial class FrmSelection : Form
    {

        private object monsterChoice;
        private object weaponChoice;
        private object armorChoice;
        private object itemsChoice;
        private object charmsChoice;
        private object mapsChoice;

        public FrmSelection()
        {
            InitializeComponent();

            //Takes list of monster names from monster class
            this.lstMonster.DataSource = Monster.Monsters;
            this.lstMonster.DisplayMember = "monsterName";
            this.lstMonster2.DataSource = Monster.Monsters;
            this.lstMonster2.DisplayMember = "monsterName";
            this.lstMonster3.DataSource = Monster.Monsters;
            this.lstMonster3.DisplayMember = "Name";
        }

        public FrmSelection(object selectedItem1, object selectedItem2, object selectedItem3, object selectedItem4, object selectedItem5, object selectedItem6) : this()
        {
            
            this.monsterChoice = Convert.ToInt32(selectedItem1);
            this.weaponChoice = Convert.ToInt32(selectedItem2);
            this.armorChoice = Convert.ToInt32(selectedItem3);
            this.itemsChoice = Convert.ToInt32(selectedItem4);
            this.charmsChoice = Convert.ToInt32(selectedItem5);
            this.mapsChoice = Convert.ToInt32(selectedItem6);

            if (monsterChoice.Equals(3))
            {

            }
            else if (monsterChoice.Equals(2))
            {

            }
            else
            {

            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            new FrmOutput().Show();
            this.Hide();
            Focus();
        }
    }
}
