using CarLand.Database;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
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
    public partial class Login : MetroForm
    {
        public DBUser _appUser = new DBUser();

        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var username = metroTextBox1.Text;
            var password = metroTextBox2.Text;
            if (username == "")
            {
                error.SetError(metroTextBox1, "Campo Obrigatório");
            }
            if (password == "")
            {
                error.SetError(metroTextBox2, "Campo Obrigatório");
            }
            if (password != "" && username != "")
            {
                var user = _appUser.GetUser(username, password);
                if (user.Id != 0)
                {
                    if (user.isAdmin)
                    {
                        FrmPrincipal admin = new FrmPrincipal();
                        admin.User = user;
                        this.Hide();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        FrmUsuario client = new FrmUsuario();
                        client.User = user;
                        this.Hide();
                        client.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }
            }
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            DateTime horario = DateTime.Now;
            datetime.Text = horario.ToString();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            Esqueceu esqueceu = new Esqueceu();
            esqueceu.ShowDialog();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            Registrar_se register = new Registrar_se();
            register.ShowDialog();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Carros car = new Carros();
            this.Hide();
            car.ShowDialog();
            this.Close();
        }
    }
}
