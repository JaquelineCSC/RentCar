using CarLand.Domain.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Logout
{
    public partial class AboutUs : MetroForm
    {
        public User User{ get; set; }

        public AboutUs()
        {
            InitializeComponent();
            User = new User();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=5535988246689");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/marcellodeabreudasilva/?hl=pt-br");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MM-CC-LL");
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=5535992314528");
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/paulo_s_m/?hl=pt-br");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/martinez30");
        }

        private void metroLink9_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=5535988034878");
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/ramires_035/?hl=pt-br");
        }

        private void metroLink7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ramires4878");
        }

        private void metroLink12_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=5535988099051");
        }

        private void metroLink11_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/samu.pereira17/");
        }

        private void metroLink10_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Huntes");
        }

        private void metroLink16_Click(object sender, EventArgs e)
        {
            FormClient form = new FormClient();
            form.User = User;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
