using CarLand.Domain.Entities;
using CarLand.Forms.Car;
using CarLand.Forms.Client;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public User User { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
            StyleManagerControllers(metroStyleManager1);
            this.StyleManager = metroStyleManager1;
            panelSettings.Visible = false;
            panelSettings.Location = new Point(1276, 28);
        }

        public void StyleManagerControllers(MetroStyleManager manager)
        {
            tabControlPrincipal.StyleManager = manager;
            tabControl.StyleManager = manager;
            metroPanel2.StyleManager = manager;
            themes.StyleManager = manager;
            styles.StyleManager = manager;
            metroTabPage2.StyleManager = manager;
            metroTabPage3.StyleManager = manager;
            panelSettings.StyleManager = manager;
            metroLinkLogout.StyleManager = manager;
            carsTile.StyleManager = manager;
            clientsTile.StyleManager = manager;
            employeeTile.StyleManager = manager;
            listRentTile.StyleManager = manager;
            paymentTile.StyleManager = manager;
            rentTile.StyleManager = manager;
            reportTile.StyleManager = manager;
            settingsTile.StyleManager = manager;
        }

        private void setColor(object sender, EventArgs e)
        {
            MetroButton linkSender = (MetroButton)sender;

            switch (linkSender.Tag)
            {
                case "Orange":
                    metroStyleManager1.Style = MetroColorStyle.Orange;
                    break;
                case "Green":
                    metroStyleManager1.Style = MetroColorStyle.Green;
                    break;
                case "Pink":
                    metroStyleManager1.Style = MetroColorStyle.Pink;
                    break;
                case "Purple":
                    metroStyleManager1.Style = MetroColorStyle.Purple;
                    break;
                case "Red":
                    metroStyleManager1.Style = MetroColorStyle.Red;
                    break;
                case "Silver":
                    metroStyleManager1.Style = MetroColorStyle.Silver;
                    break;
                case "Yellow":
                    metroStyleManager1.Style = MetroColorStyle.Yellow;
                    break;
                case "Brown":
                    metroStyleManager1.Style = MetroColorStyle.Brown;
                    break;
                case "Magenta":
                    metroStyleManager1.Style = MetroColorStyle.Magenta;
                    break;
                case "Blue":
                    metroStyleManager1.Style = MetroColorStyle.Blue;
                    break;
                case "Lime":
                    metroStyleManager1.Style = MetroColorStyle.Lime;
                    break;
                case "Teal":
                    metroStyleManager1.Style = MetroColorStyle.Teal;
                    break;
            }
        }

        private void setDark(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
        }

        private void setLight(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroThemeStyle.Light;
        }

        public Color GetColor(MetroColorStyle color)
        {
            Color retorno = new Color();
            switch (color)
            {
                case MetroColorStyle.Orange:
                    retorno = Color.DarkOrange;
                    break;
                case MetroColorStyle.Green:
                    retorno = Color.Green;
                    break;
                case MetroColorStyle.Pink:
                    retorno = Color.Pink;
                    break;
                case MetroColorStyle.Purple:
                    retorno = Color.Purple;
                    break;
                case MetroColorStyle.Red:
                    retorno = Color.Red;
                    break;
                case MetroColorStyle.Silver:
                    retorno = Color.Silver;
                    break;
                case MetroColorStyle.Yellow:
                    retorno = Color.Yellow;
                    break;
                case MetroColorStyle.Brown:
                    retorno = Color.SaddleBrown;
                    break;
                case MetroColorStyle.Magenta:
                    retorno = Color.Magenta;
                    break;
                case MetroColorStyle.Blue:
                    retorno = Color.DeepSkyBlue;
                    break;
                case MetroColorStyle.Lime:
                    retorno = Color.Lime;
                    break;
                case MetroColorStyle.Teal:
                    retorno = Color.Teal;
                    break;
            }
            return retorno;
        }

        private void ShowLogin(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void ShowListCar(object sender, EventArgs e)
        {
            ListCar listCar = new ListCar();
            listCar.ShowDialog();
        }

        private void ShowCars(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.User = User;
            this.Hide();
            car.ShowDialog();
            this.Close();
        }

        private void settingsShowAndHide(object sender, EventArgs e)
        {
            if (panelSettings.Visible)
            {
                esconder.Enabled = true;
            }
            else
            {
                panelSettings.Visible = true;
                mostrar.Enabled = true;
            }
        }

        private void mostrar_Tick(object sender, EventArgs e)
        {
            if (panelSettings.Location.X > 1007)
            {
                panelSettings.Location = new Point(panelSettings.Location.X - 18, panelSettings.Location.Y);
            }
            else
            {
                mostrar.Enabled = false;
            }
        }

        private void esconder_Tick(object sender, EventArgs e)
        {
            if (panelSettings.Location.X < 1276)
            {
                panelSettings.Location = new Point(panelSettings.Location.X + 18, panelSettings.Location.Y);
            }
            else
            {
                panelSettings.Visible = false;
                esconder.Enabled = false;
            }
        }

        private void clientsTile_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.ShowDialog();
            this.Close();
        }

        private void employeeTile_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            this.Hide();
            funcionarios.ShowDialog();
            this.Close();
        }

        private void listRentTile_Click(object sender, EventArgs e)
        {
            AluguelCliente aluguelcliente = new AluguelCliente();
            this.Hide();
            aluguelcliente.ShowDialog();
            this.Close();
        }
    }
}
