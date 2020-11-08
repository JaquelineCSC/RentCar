using CarLand.Domain.Entities;
using CarLand.Forms;
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
    public partial class FrmUsuario : MetroFramework.Forms.MetroForm
    {
        public User User { get; set; }

        public FrmUsuario(MetroStyleManager manager)
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
    }
}
