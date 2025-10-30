using zhFelkeszito2.View;

namespace zhFelkeszito2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kisállatHozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddPet = new AddPet();
            AddPet.ShowDialog();
        }
    }
}
