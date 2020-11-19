using CarLand.Domain.Entities;
using CarLand.Forms;
using CarLand.Forms.Client;
using CarLand.Forms.Logout;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;

namespace CarLand
{
    public partial class FormClient : MetroForm
    {
        public User User { get; set; }

        public FormClient()
        {
            InitializeComponent();
            panelSettings.Visible = false;
            panelSettings.Location = new Point(1276, 28);

            this.StyleManager = metroStyleManager1;

            if (int.Parse(Properties.Settings.Default["Theme"].ToString()) == 0)
            {
                this.StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                this.StyleManager.Theme = MetroThemeStyle.Light;
            }

            setThemeInControls(StyleManager.Theme);
        }

        public void setThemeInControls(MetroThemeStyle style)
        {
            metroLinkLogout.Theme = style;
            metroTabControl1.Theme= style;
            metroTabPage1.Theme= style;
            panelSettings.Theme = style;
            metroPanel2.Theme = style;
            metroLabel6.Theme = style;
            metroTabControl1.Theme = style;
            metroTabPage1.Theme = style;
            metroTabPage3.Theme = style;
            themes.Theme = style;
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

        private void metroLinkLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void metroTile5_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs(this.StyleManager);
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
        private void metroTile6_Click(object sender, EventArgs e)
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
    }
}
