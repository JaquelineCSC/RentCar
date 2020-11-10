using CarLand.Domain.Entities;
using CarLand.Forms.Car;
using MetroFramework;
using MetroFramework.Components;
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
            this.StyleManager = manager;
            panelSettings.Visible = false;
            panelSettings.Location = new Point(1276, 28);
        }

        public void Load_Theme(MetroThemeStyle style)
        {
            manager.Theme = style;
            metroTabPage1.Theme = manager.Theme;
            metroTabControl1.Theme = manager.Theme;
            metroLabel6.Theme = manager.Theme;
            metroPanel2.Theme = manager.Theme;
            settings.Theme = manager.Theme;
            metroTabPage3.Theme = manager.Theme;
            metroTabControl2.Theme = manager.Theme;
            metroTabPage2.Theme = manager.Theme;
            panelSettings.Theme = manager.Theme;

        }

        public void Load_Style(MetroColorStyle style)
        {

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

        private void Reload(object sender, EventArgs e)
        {
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroLinkLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ListCar listCar = new ListCar();
            listCar.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Carros car = new Carros();
            car.User = User;
            this.Hide();
            car.ShowDialog();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
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

        private void orange_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Orange);
        }

        private void green_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Green);

        }

        private void pink_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Pink);

        }

        private void silver_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Silver);

        }

        private void red_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Red);

        }

        private void purple_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Purple);

        }

        private void yellow_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Yellow);

        }

        private void brown_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Brown);
        }

        private void magenta_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Magenta);

        }

        private void teal_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Teal);
        }

        private void lime_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Lime);

        }

        private void blue_Click(object sender, EventArgs e)
        {
            Load_Style(MetroColorStyle.Blue);
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

        private void esconder_Tick_1(object sender, EventArgs e)
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

        private void metroButton13_Click_2(object sender, EventArgs e)
        {
            Load_Theme(MetroThemeStyle.Dark);
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            Load_Theme(MetroThemeStyle.Light);
        }
    }
}
