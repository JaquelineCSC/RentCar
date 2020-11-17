using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
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

        public ListCar(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Style_Page();
            _appCar = new DBCar();
            _appImage = new DBImage();
        }

        public void Style_Page()
        {
            //Theme
            metroGrid1.Theme = this.StyleManager.Theme;

            //Style
            metroGrid1.Style = this.StyleManager.Style;
        }

        private void ListCar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'listaCar.Cars'. Você pode movê-la ou removê-la conforme necessário.
            this.carsTableAdapter1.Fill(this.listaCar.Cars);
            // TODO: esta linha de código carrega dados na tabela 'listCarRamires.Car'. Você pode movê-la ou removê-la conforme necessário.
            this.carTableAdapter.Fill(this.listCarRamires.Car);
            
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
                int id = int.Parse(RowView["Código"].ToString());
                _appImage.Delete(id);
                _appCar.Delete(id);
                MetroMessageBox.Show(this, "Carro deletado com sucesso", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                ListCar_Load(this, new EventArgs());
            }
            else
            {
                MetroMessageBox.Show(this, "Selecione a linha que deseja editar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
        }
    }
}
