using CarLand.Forms.Aluguel;
using MetroFramework;
using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace CarLand.Forms.Client
{
    public partial class ListCar : MetroFramework.Forms.MetroForm
    {
        public DataRowView RowView { get; set; }

        public ListCar()
        {
            InitializeComponent();
        }

        private void AluguelCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'listRentRamires.Rent'. Você pode movê-la ou removê-la conforme necessário.
            this.rentTableAdapter.Fill(this.listRentRamires.Rent);
            // TODO: This line of code loads data into the 'listRent.RentViewWithoutCards' table. You can move, or remove it, as needed.
            this.rentViewWithoutCardsTableAdapter.Fill(this.listRent.RentViewWithoutCards);
            // TODO: This line of code loads data into the 'listRent1.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter1.Fill(this.listRent1.Rent);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if (RowView != null)
            {
                RentDetails detalhealuguel = new RentDetails();
                detalhealuguel.Rent.Id = int.Parse(RowView["idRent"].ToString());
                detalhealuguel.Rent.idCar = int.Parse(RowView["idCar"].ToString());
                if (RowView["idEmployee"].ToString() != "")
                {
                    detalhealuguel.Rent.idEmployee = int.Parse(RowView["idEmployee"].ToString());
                }
                detalhealuguel.Rent.idClient = int.Parse(RowView["idClient"].ToString());
                detalhealuguel.Rent.PickUpDate = DateTime.Parse(RowView["PickUpTime"].ToString());
                detalhealuguel.Rent.DropOffDate = DateTime.Parse(RowView["DropOfTime"].ToString());
                detalhealuguel.Rent.Value = double.Parse(RowView["Amount"].ToString());
                detalhealuguel.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Selecione a linha que deseja editar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            AluguelCliente_Load(this, new EventArgs());
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                RowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
            }
        }
    }
}
