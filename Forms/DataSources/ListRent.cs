using CarLand.Forms.Aluguel;
using MetroFramework;
using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace CarLand.Forms.Client
{
    public partial class ListCar : MetroFramework.Forms.MetroForm
    {
        public DataRowView RowView { get; set; }

        public ListCar(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
        }

        public void Load_Page()
        {
            //Theme
            metroGrid1.Theme = this.StyleManager.Theme;
            metroLink3.Theme = this.StyleManager.Theme;

            //Style
            metroGrid1.Style = this.StyleManager.Style;
            metroLink3.Style = this.StyleManager.Style;

        }

        private void AluguelCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentView._RentView' table. You can move, or remove it, as needed.
            this.rentViewTableAdapter.Fill(this.rentView._RentView);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if (RowView != null)
            {
                RentDetails form = new RentDetails(this.StyleManager);
                form.Rent.Id = int.Parse(RowView["Id Aluguel"].ToString());
                Database.DBCar _appCar = new Database.DBCar();
                Database.DBClient _appClient = new Database.DBClient();
                var car = _appCar.GetCar(branch: RowView["Marca"].ToString(), model: RowView["Modelo"].ToString(), color: RowView["Cor"].ToString(), year: RowView["Ano"].ToString());
                form.Rent.idCar = car.Id;
                if (RowView["Funcionario"].ToString() != "")
                {
                    Database.DBEmployee _appEmployee = new Database.DBEmployee();
                    form.Rent.idEmployee = _appEmployee.GetEmployee(employeeName: RowView["Funcionario"].ToString()).Id;
                }
                form.Rent.idClient = (_appClient.GeClientByName(RowView["Cliente"].ToString())).Id;
                form.Rent.PickUpDate = DateTime.Parse(RowView["Data Retirada"].ToString());
                form.Rent.DropOffDate = DateTime.Parse(RowView["Data Devolução"].ToString());
                form.Rent.Value = double.Parse(RowView["Valor"].ToString());
                form.ShowDialog();
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

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                RowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
            }
        }
    }
}
