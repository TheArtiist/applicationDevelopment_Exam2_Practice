using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhFelkeszito2.View
{
    public partial class AddPet : Form
    {
        public AddPet()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameTB.Text.Equals("") || genderRB.Text.Equals("") 
                || ageNum.Value < 0 || weightNum.Value < 0 || speciesCombo.Text.Equals(""))
            {
                var msg = MessageBox.Show("Nem maradhat üresen mező");
            }
            string tmpName = nameTB.Text;
            bool ischecked = genderRB.Checked;
            int tmpAge = (int)ageNum.Value;
            int tmpWeight = (int)weightNum.Value;
            string tmpSpecies = speciesCombo.Text; 

        }
    }
}
