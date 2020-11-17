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

            this.StyleManager = metroStyleManager1;

            if (int.Parse(Properties.Settings.Default["Theme"].ToString()) == 0)
            {
                StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                StyleManager.Theme = MetroThemeStyle.Light;
            }
            Load_Page();
        }

        private void Load_Page()
        {
            metroLinkLogout.Theme = this.StyleManager.Theme;
            metroTabControl1.Theme = this.StyleManager.Theme;
            metroTabPage1.Theme = this.StyleManager.Theme;
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
            Cars form = new Cars(this.StyleManager);
            form.User = User;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(this.StyleManager);
            form.User = User;
            form.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Wallet form = new Wallet(this.StyleManager);
            Database.DBClient _appClient = new Database.DBClient();
            form.Client = _appClient.GetClientByUser(User.Id);
            form.ShowDialog();
        }
    }
}
