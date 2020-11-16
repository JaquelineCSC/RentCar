using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Car
{
    public partial class CarAmount : MetroForm
    {
        public DataRowView RowView { get; set; }
        public Database.DBCar _appCar { get; set; }
        public Database.DBAmount _appAmount { get; set; }

        public CarAmount()
        {
            InitializeComponent();
            _appCar = new Database.DBCar();
            _appAmount = new Database.DBAmount();
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
            SetValueCar form = new SetValueCar();
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
