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


        private void Login_Load(object sender, EventArgs e)
        {
            this.StyleManager = manager;
            panelSettings.Visible = false;
            panelSettings.Location = new Point(1276, 28);
        }

        private void Load_Theme(MetroThemeStyle style)
        {
            manager.Theme = style;
            metroPanel2.Theme = style;
            settings.Theme = style;
            metroTabPage1.Theme = style;
            metroTabControl1.Theme = style;
            metroTabPage2.Theme = style;
            panelSettings.Theme = style;
            metroLabel4.Theme = style;
            metroLabel5.Theme = style;
            metroLabel2.Theme = style;
            metroLabel6.Theme = style;
            metroLinkVoltar.Theme = style;
            metroLink1.Theme = style;
            datetime.Theme = style;
        }

        public void Load_Style(MetroColorStyle style)
        {
            metroTabControl1.Style = style;
            settings.Style = style;
            metroLabel2.Style = style;
            metroButton1.BackColor = GetColor(style);
            manager.Style = style;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var username = metroTextBox1.Text;
            var password = metroTextBox2.Text;
            if(username == "")
            {
                error.SetError(metroTextBox1, "Campo Obrigatório");
            }
            if(password == "")
            {
                error.SetError(metroTextBox2, "Campo Obrigatório");
            }
            if (password != "" && username != "")
            {
                    var user = _appUser.GetUser(username, int.Parse(password));
                if(user.Id != 0)
                {
                    if (user.Admin)
                    {
                        FrmPrincipal admin = new FrmPrincipal(this.StyleManager);
                        admin.User = user;
                        this.Hide();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        FrmUsuario client = new FrmUsuario(this.StyleManager);
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

        private void timer1_Tick(object sender, EventArgs e)
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

        private void metroLinkVoltar_Click(object sender, EventArgs e)
        {
            esconder.Enabled = true;
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
                metroLink1.Visible = true;
            }
        }

        private void metroButton12_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
                Load_Theme(MetroThemeStyle.Light);
        }

        private void metroButton13_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
                Load_Theme(MetroThemeStyle.Dark);
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

        private void relogio_Tick(object sender, EventArgs e)
        {
            DateTime horario = DateTime.Now;
            datetime.Text = horario.ToString();
        }

        private void hoverCor(object sender, EventArgs e)
        {
        }
      
        private void metroLabel4_Click(object sender, EventArgs e)
        {
            Esqueceu esqueceu = new Esqueceu(this.StyleManager);
            esqueceu.ShowDialog();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            Registrar_se register = new Registrar_se(this.StyleManager);
            register.ShowDialog();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroLink1.Visible = false;
            panelSettings.Visible = true;
            mostrar.Enabled = true;
        }
    }
}
