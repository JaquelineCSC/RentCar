using CarLand.Database;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarLand.Forms.Car
{
    public partial class ListCar : MetroForm
    {
        public DataRowView RowView { get; set; }
        public DBCar _appCar { get; set; }
        public DBImage _appImage { get; set; }

        public ListCar()
        {
            InitializeComponent();
            _appCar = new DBCar();
            _appImage = new DBImage();
        }

        private void ListCar_Load(object sender, EventArgs e)
        {
            this.carTableAdapter1.Fill(this.integradoraDataSet1.Car);
        }

        private void toolTip(object sender, EventArgs e)
        {
            var botao = (MetroLink)sender;
            switch (botao.TabIndex)
            {
                case 1:
                    metrotooltipo.Show("Criar", botao);
                    break;
                case 2:
                    metrotooltipo.Show("Editar", botao);
                    break;
                case 3:
                    metrotooltipo.Show("Deletar", botao);
                    break;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Create createForm = new Create();
            createForm.ShowDialog();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if(RowView != null)
            {
                EditCar form = new EditCar();
                form.Car.Id = int.Parse(RowView["idCar"].ToString());
                form.Car.Board = RowView["Board"].ToString();
                form.Car.Branch = RowView["Branch"].ToString();
                form.Car.Color = RowView["Color"].ToString();
                form.Car.Doors = int.Parse(RowView["Doors"].ToString());
                form.Car.Fuel = RowView["Fuel"].ToString();
                form.Car.Model = RowView["Model"].ToString();
                form.Car.Year = int.Parse(RowView["Year"].ToString());
                form.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Selecione a linha que deseja editar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning , 100);
            }
        }

        private void metroGrid1_CellContentClick(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                RowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            if (RowView != null)
            {
                string board = RowView["Board"].ToString();
                int id = int.Parse(RowView["idCar"].ToString());
                _appImage.Delete(id);
                _appCar.Delete(board);
                MetroMessageBox.Show(this, "Carro deletado com sucesso", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            else
            {
                MetroMessageBox.Show(this, "Selecione a linha que deseja editar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
        }
    }
}
