using MetroFramework;
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
    public partial class SetValueCar : MetroForm
    {
        public Domain.Entities.Car Car { get; set; }
        public Database.DBAmount _appAmount { get; set; }
        public bool isNew { get; set; }

        public SetValueCar()
        {
            InitializeComponent();
            Car = new Domain.Entities.Car();
            _appAmount = new Database.DBAmount();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(value.Text != "")
            {
                Domain.Entities.AmountCar amount = new Domain.Entities.AmountCar()
                {
                    idCar = Car.Id,
                    Amount = decimal.Parse(value.Text),
                };
                try
                {
                    if (isNew)
                    {
                        _appAmount.Insert(amount);
                        Database.DBCar _appCar = new Database.DBCar();
                        _appCar.Provide(Car.Id);
                        MetroMessageBox.Show(this, "Valor Adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                    }
                    else
                    {
                        _appAmount.Update(amount);
                        MetroMessageBox.Show(this, "Valor Editado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                    }
                }
                catch(Exception exp)
                {
                    MetroMessageBox.Show(this, "Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }

            }
        }
    }
}
