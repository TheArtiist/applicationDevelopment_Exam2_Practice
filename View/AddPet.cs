using IdGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zhFelkeszito2.Controller;
using zhFelkeszito2.Model;

namespace zhFelkeszito2.View
{
    internal partial class AddPet : Form
    {
        private readonly PetController _petController;
        public AddPet(PetController controller)
        {
            InitializeComponent();
            this._petController = controller;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(nameTB.Text.Equals("") || genderRB.Text.Equals("") 
                || ageNum.Value < 0 || weightNum.Value < 0 || speciesCombo.Text.Equals(""))
            {
                var msg = MessageBox.Show("Nem maradhat üresen mező","Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var generator = new IdGenerator(0);
            var id = generator.CreateId();
            string tmpName = nameTB.Text;
            bool ischecked = genderRB.Checked;
            int tmpAge = (int)ageNum.Value;
            int tmpWeight = (int)weightNum.Value;
            string tmpSpecies = speciesCombo.Text;
            Pet pet;
            if (ischecked)
            {
                pet = new Pet(id,tmpName, true, tmpAge,tmpWeight,tmpSpecies); 
            }
            else
            {
                pet = new Pet(id,tmpName, false, tmpAge, tmpWeight, tmpSpecies);
            }

            if (!_petController.AddPet(pet))
            {
                var msg = MessageBox.Show("Nem került hozzáadásra az állat", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
