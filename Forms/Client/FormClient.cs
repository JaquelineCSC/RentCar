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

            panelSettings2.Visible = false;
            panelSettings2.Location = new Point(1276, 28);

            this.StyleManager = metroStyleManager2;

            if (int.Parse(Properties.Settings.Default["Theme"].ToString()) == 0)
            {
                StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                StyleManager.Theme = MetroThemeStyle.Light;
            }

            setThemeInControls2(StyleManager.Theme);

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

        private void metroButton13_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < 2; i++)
                {
                    this.StyleManager.Theme = MetroThemeStyle.Dark;
                    setThemeInControls2(MetroThemeStyle.Dark);
                }

                Properties.Settings.Default["Theme"] = 0;
                Properties.Settings.Default.Save();
            
        }

        private void setLight2_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < 2; i++)
                {
                    this.StyleManager.Theme = MetroThemeStyle.Light;
                    setThemeInControls2(MetroThemeStyle.Light);
                }

                Properties.Settings.Default["Theme"] = 1;
                Properties.Settings.Default.Save();
            
        }

        public void setThemeInControls2(MetroThemeStyle style)
        {
            metroTabPage1.Theme = style;
            metroTabPage3.Theme = style;
            metroPanel2.Theme = style;
            themes.Theme = style;
            panelSettings2.Theme = style;
            metroTabControl1.Theme = style;
        }

        private void settingsTile2_Click(object sender, EventArgs e)
        {
            if (panelSettings2.Visible)
            {
                esconder2.Enabled = true;
            }
            else
            {
                panelSettings2.Visible = true;
                mostrar2.Enabled = true;
            }
        }

        private void mostrar2_Tick(object sender, EventArgs e)
        {
            if (panelSettings2.Location.X > 1007)
            {
                panelSettings2.Location = new Point(panelSettings2.Location.X - 18, panelSettings2.Location.Y);
            }
            else
            {
                mostrar2.Enabled = false;
            }
        }

        private void esconder2_Tick(object sender, EventArgs e)
        {
            if (panelSettings2.Location.X < 1276)
            {
                panelSettings2.Location = new Point(panelSettings2.Location.X + 18, panelSettings2.Location.Y);
            }
            else
            {
                panelSettings2.Visible = false;
                esconder2.Enabled = false;
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
