using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Data;

namespace CarLand.Forms.Car
{
    public partial class CarAmount : MetroForm
    {
        public DataRowView RowView;
        public readonly Database.DBCar _appCar = new Database.DBCar();
        public readonly Database.DBAmount _appAmount = new Database.DBAmount();

        public CarAmount(MetroStyleManager manager)
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
        private void CarAmount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amountCar._AmountCar' table. You can move, or remove it, as needed.
            this.amountCarTableAdapter.Fill(this.amountCar._AmountCar);
        }
        private void rowViewSelect(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                RowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
            }
        }
        private void metroLink3_Click(object sender, EventArgs e)
        {
            SetValueCar form = new SetValueCar(this.StyleManager);
            Domain.Entities.Car car = _appCar.GetCar(id: int.Parse(RowView["idCar"].ToString()));
            form.Car = car;
            var isNew = _appAmount.GetAmount(car.Id);
            if(isNew.idCar != 0)
                form.isNew = false;
            else
                form.isNew = true;

            form.ShowDialog();
        }
    }
}
