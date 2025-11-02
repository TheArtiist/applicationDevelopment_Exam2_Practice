using zhFelkeszito2.Controller;
using zhFelkeszito2.Dao;
using zhFelkeszito2.View;

namespace zhFelkeszito2
{
    public partial class Form1 : Form
    {
        private PetController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new PetController(new AdoPetDao());
            LoadPetsUI();
            PetDataGridView.Visible = false;
        }

        private void LoadPetsUI()
        {
            PetDataGridView.DataSource = null;
            PetDataGridView.Columns.Clear();
            PetDataGridView.DataSource = controller.GetAllPets().ToList();
            PetDataGridView.ReadOnly = true;
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            PetDataGridView.Columns.Add(deleteButtonColumn);

        }

        private void kisállatHozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddPet = new AddPet(controller);
            AddPet.ShowDialog();
        }

        private void listázásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetDataGridView.Visible = true;
            LoadPetsUI();
        }
    }
}
