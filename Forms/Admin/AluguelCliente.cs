using CarLand.Forms.Aluguel;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Client
{
    public partial class AluguelCliente : MetroFramework.Forms.MetroForm
    {
        public DataRowView RowView { get; set; }

        public AluguelCliente()
        {
            InitializeComponent();
        }

        private void AluguelCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lisRent.Rent'. Você pode movê-la ou removê-la conforme necessário.
            this.rentTableAdapter.Fill(this.lisRent.Rent);

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if (RowView != null)
            {
                DetalheAluguel detalhealuguel = new DetalheAluguel();
                detalhealuguel.Rent.Id = int.Parse(RowView["idRent"].ToString());
                detalhealuguel.Rent.idCar = int.Parse(RowView["idCar"].ToString());
                detalhealuguel.Rent.idEmployee = int.Parse(RowView["idEmployee"].ToString());
                detalhealuguel.Rent.idClient = int.Parse(RowView["idClient"].ToString());
                detalhealuguel.Rent.PickTime = int.Parse(RowView["PickUpTime"].ToString());
                detalhealuguel.Rent.DropTime = int.Parse(RowView["DropOfTime"].ToString());
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
