using CarLand.Domain.Entities;
using CarLand.Forms;
using CarLand.Forms.Client;
using CarLand.Forms.Logout;
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

namespace CarLand
{
    public partial class FormClient : MetroFramework.Forms.MetroForm
    {
        public User User { get; set; }

        public FormClient()
        {
            InitializeComponent();
        }

        public void Load_Theme(MetroThemeStyle style)
        {

        }

        public void Load_Style(MetroColorStyle style)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
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

        private void metroTile5_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs();
            form.User = User;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Cars form = new Cars();
            form.User = User;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.User = User;
            form.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }
    }
}
