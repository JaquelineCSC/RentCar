using CarLand.Domain.Interface;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CarLand.Forms.Car
{
    public partial class SetValueCar : MetroForm
    {
        public bool isNew { get; set; }

        public Domain.Entities.Car Car = new Domain.Entities.Car();
        public readonly Database.DBAmount _appAmount = new Database.DBAmount();
        
        public SetValueCar(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
        }
        public void Load_Page()
        {
            value.Theme = this.StyleManager.Theme;

            value.Style = this.StyleManager.Style;

            Colors colors = new Colors();
            metroButton1.BackColor = colors.GetColor(this.StyleManager.Style);
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
                    this.Close();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }

            }
        }
    }
}
