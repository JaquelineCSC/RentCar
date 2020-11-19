using CarLand.Forms.Aluguel;
using MetroFramework;
using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace CarLand.Forms.Client
{
    public partial class ListCar : MetroForm
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
            this.rentViewTableAdapter.Fill(this.rentView._RentView);
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
                form.Rent.idClient = (_appClient.GetClientByName(RowView["Cliente"].ToString())).Id;
                form.Rent.PickUpDate = DateTime.Parse(RowView["Retirada"].ToString());
                form.Rent.DropOffDate = DateTime.Parse(RowView["Devolução"].ToString());
                form.Rent.Value = double.Parse(RowView["Valor"].ToString().Replace("R$", ""));
                switch (RowView["Tipo Pagamento"].ToString())
                {
                    case "1":
                        form.Rent.PaymentType = Domain.Entities.PaymentTypeEnum.Billet;
                        break;
                    case "2":
                        form.Rent.PaymentType = Domain.Entities.PaymentTypeEnum.Money;
                        break;
                    case "3":
                        form.Rent.PaymentType = Domain.Entities.PaymentTypeEnum.Card;
                        break;
                }
                form.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Selecione a linha que deseja editar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
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
