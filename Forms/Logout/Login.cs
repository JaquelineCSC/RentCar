using CarLand.Database;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Login : MetroForm
    {
        public readonly DBUser _appUser = new DBUser();

        public Login()
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
            //Theme
            metroButton1.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel4.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            metroLink2.Theme = this.StyleManager.Theme;
            metroTextBox1.Theme = this.StyleManager.Theme;
            metroTextBox2.Theme = this.StyleManager.Theme;
            datetime.Theme = this.StyleManager.Theme;
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
                var user = _appUser.GetUser(userName: username, password: password);
                if (user.Id != 0)
                {
                    if (user.isAdmin)
                    {
                        FormMain admin = new FormMain();
                        admin.User = user;
                        this.Hide();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        FormClient client = new FormClient();
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
            ForgotPassword esqueceu = new ForgotPassword(this.StyleManager);
            esqueceu.ShowDialog();
        }
        private void metroLabel5_Click(object sender, EventArgs e)
        {
            Register register = new Register(this.StyleManager);
            register.ShowDialog();
        }
        private void metroLink2_Click(object sender, EventArgs e)
        {
            Cars car = new Cars(this.StyleManager);
            this.Hide();
            car.ShowDialog();
            this.Close();
        }
        private void metroTextBox2_ButtonClick(object sender, EventArgs e)
        {
            if (metroTextBox2.CustomButton.TabIndex == 1)
            {
                metroTextBox2.UseSystemPasswordChar = true;
                metroTextBox2.CustomButton.Image = System.Drawing.Image.FromFile(Path.Combine(Servers.path + @"\Database\Imagens Eye\", "visibilidade.png"));
                metroTextBox2.CustomButton.TabIndex = 2;
            }
            else
            {
                metroTextBox2.UseSystemPasswordChar = false;
                metroTextBox2.CustomButton.Image = System.Drawing.Image.FromFile(Path.Combine(Servers.path + @"\Database\Imagens Eye\", "invisible.png"));
                metroTextBox2.CustomButton.TabIndex = 1;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            metroTextBox2.CustomButton.Image = System.Drawing.Image.FromFile(Path.Combine(Servers.path + @"\Database\Imagens Eye\","invisible.png"));
            metroTextBox2.CustomButton.TabIndex = 1;
        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
