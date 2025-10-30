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
            string tmpName = nameTB.Text;
            bool ischecked = genderRB.Checked;
            int tmpAge = (int)ageNum.Value;
            int tmpWeight = (int)weightNum.Value;
            string tmpSpecies = speciesCombo.Text; 

        }
    }
}
