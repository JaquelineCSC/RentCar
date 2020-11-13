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
            panelSettings.Visible = false;
            panelSettings.Location = new Point(1276, 28);

            this.StyleManager = metroStyleManager1;

            if (int.Parse(Properties.Settings.Default["Theme"].ToString()) == 0)
            {
                StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                StyleManager.Theme = MetroThemeStyle.Light;
            }

            setThemeInControls(StyleManager.Theme);

            switch (Properties.Settings.Default["Color"].ToString())
            {
                case "Orange":
                    StyleManager.Style = MetroColorStyle.Orange;
                    break;
                case "Blue":
                    StyleManager.Style = MetroColorStyle.Blue;
                    break;
                case "Yellow":
                    StyleManager.Style = MetroColorStyle.Yellow;
                    break;
                case "Red":
                    StyleManager.Style = MetroColorStyle.Red;
                    break;
                case "Silver":
                    StyleManager.Style = MetroColorStyle.Silver;
                    break;
                case "Green":
                    StyleManager.Style = MetroColorStyle.Green;
                    break;
                case "Brown":
                    StyleManager.Style = MetroColorStyle.Brown;
                    break;
                case "Magenta":
                    StyleManager.Style = MetroColorStyle.Magenta;
                    break;
                case "Pink":
                    StyleManager.Style = MetroColorStyle.Pink;
                    break;
                case "Purple":
                    StyleManager.Style = MetroColorStyle.Purple;
                    break;
                case "Lime":
                    StyleManager.Style = MetroColorStyle.Lime;
                    break;
                case "Teal":
                    this.StyleManager.Style = MetroColorStyle.Teal;
                    break;
            }

            setColorInControls(StyleManager.Style);
        }

        public void setColorInControls(MetroColorStyle style)
        {
            tabControlPrincipal.Style = style;
            tabControl.Style = style;
            metroPanel2.Style = style;
            themes.Style = style;
            styles.Style = style;
            metroTabPage2.Style = style;
            metroTabPage3.Style = style;
            panelSettings.Style = style;
            metroLinkLogout.Style = style;
            carsTile.Style = style;
            clientsTile.Style = style;
            employeeTile.Style = style;
            listRentTile.Style = style;
            paymentTile.Style = style;
            rentTile.Style = style;
            reportTile.Style = style;
            settingsTile.Style = style;
        }

        public void setThemeInControls(MetroThemeStyle style)
        {
            tabControlPrincipal.Theme = style;
            tabControl.Theme = style;
            metroPanel2.Theme = style;
            themes.Theme = style;
            styles.Theme = style;
            metroTabPage2.Theme = style;
            metroTabPage3.Theme = style;
            panelSettings.Theme = style;
            metroLinkLogout.Theme = style;
            carsTile.Theme = style;
            clientsTile.Theme = style;
            employeeTile.Theme = style;
            listRentTile.Theme = style;
            metroLabel6.Theme = style;
            paymentTile.Theme = style;
            rentTile.Theme = style;
            reportTile.Theme = style;
            settingsTile.Theme = style;
        }

        private void setColor(object sender, EventArgs e)
        {
            MetroButton linkSender = (MetroButton)sender;
            string color = "";

            for (int i = 0; i < 2; i++)
            {

                switch (linkSender.Tag)
                {

                    case "Green":
                        this.StyleManager.Style = MetroColorStyle.Green;
                        color = "Green";
                        break;
                    case "Pink":
                        this.StyleManager.Style = MetroColorStyle.Pink;
                        color = "Pink";
                        break;
                    case "Purple":
                        this.StyleManager.Style = MetroColorStyle.Purple;
                        color = "Purple";
                        break;
                    case "Red":
                        this.StyleManager.Style = MetroColorStyle.Red;
                        color = "Red";
                        break;
                    case "Silver":
                        this.StyleManager.Style = MetroColorStyle.Silver;
                        color = "Silver";
                        break;
                    case "Yellow":
                        this.StyleManager.Style = MetroColorStyle.Yellow;
                        color = "Yellow";
                        break;
                    case "Brown":
                        this.StyleManager.Style = MetroColorStyle.Brown;
                        color = "Brown";
                        break;
                    case "Magenta":
                        this.StyleManager.Style = MetroColorStyle.Magenta;
                        color = "Magenta";
                        break;
                    case "Blue":
                        this.StyleManager.Style = MetroColorStyle.Blue;
                        color = "Blue";
                        break;
                    case "Lime":
                        this.StyleManager.Style = MetroColorStyle.Lime;
                        color = "Lime";
                        break;
                    case "Teal":
                        this.StyleManager.Style = MetroColorStyle.Teal;
                        color = "Teal";
                        break;
                    default:
                        this.StyleManager.Style = MetroColorStyle.Orange;
                        color = "Orange";
                        break;
                }
                setColorInControls(this.StyleManager.Style);
            }

            Properties.Settings.Default["Color"] = color;
            Properties.Settings.Default.Save();
        }

        private void setDark(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                this.StyleManager.Theme = MetroThemeStyle.Dark;
                setThemeInControls(MetroThemeStyle.Dark);
            }

            Properties.Settings.Default["Theme"] = 0;
            Properties.Settings.Default.Save();
        }

        private void setLight(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                this.StyleManager.Theme = MetroThemeStyle.Light;
                setThemeInControls(MetroThemeStyle.Light);
            }

            Properties.Settings.Default["Theme"] = 1;
            Properties.Settings.Default.Save();
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
            Car.ListCar listCar = new Car.ListCar();
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
            clientes.User = User;
            clientes.ShowDialog();
            this.Close();
        }

        private void employeeTile_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.ShowDialog();
        }

        private void listRentTile_Click(object sender, EventArgs e)
        {
            Client.ListCar aluguelcliente = new Client.ListCar();
            this.Hide();
            aluguelcliente.ShowDialog();
            this.Close();
        }
    }
}
