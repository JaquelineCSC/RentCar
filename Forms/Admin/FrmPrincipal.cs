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

        public FrmPrincipal(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Style(manager.Style);
            Load_Theme(manager.Theme);
        }

        public void Load_Theme(MetroThemeStyle style)
        {

        }

        public void Load_Style(MetroColorStyle style)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
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
    }
}
