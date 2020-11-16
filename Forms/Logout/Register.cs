using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Register : MetroForm
    {
        public Domain.Entities.User User { get; set; }
        public DBUser _appCar { get; set; }
        public bool userCorrect { get; set; }
        public bool passCorrect { get; set; }
        public bool confirmpassCorrect { get; set; }

        public Register()
        {
            InitializeComponent();
            _appCar = new DBUser();
        }

        public void Load_Style(MetroColorStyle style)
        {
            mtxtUsuarioClientes.Style = style;
            mtxtSenhaClientes.Style = style;
            metroTextBox1.Style = style;
        }

        public void Load_Theme(MetroThemeStyle style)
        {
            mtxtUsuarioClientes.Theme = style;
            mtxtSenhaClientes.Theme = style;
            metroTextBox1.Theme = style;
            metroLink1.Theme = style;
        }


        private void verficiarPreenchimento(object sender, System.EventArgs e)
        {
            if (mtxtUsuarioClientes.Text != "" && mtxtSenhaClientes.Text != "" && metroTextBox1.Text != "")
                metroLink1.Enabled = true;
        }

        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            if (mtxtSenhaClientes.Text == "")
            {
                errors.SetError(this.mtxtSenhaClientes, "Campo Obrigatório");
            }
            if (mtxtSenhaClientes.Text.Length < 8)
            {
                errors.SetError(this.mtxtSenhaClientes, "Insira pelo menos 8 caracteres");
            }
            if (mtxtSenhaClientes.Text.Length > 16)
            {
                errors.SetError(this.mtxtSenhaClientes, "Insira no máximo 16 caracteres");
            }
            if (metroTextBox1.Text == "")
            {
                errors.SetError(this.metroTextBox1, "Campo Obrigatório");
            }
            if (metroTextBox1.Text != mtxtSenhaClientes.Text)
            {
                errors.SetError(this.metroTextBox1, "Os campos são incompatíveis");
            }
            if (mtxtUsuarioClientes.Text != "")
            {
                errors.SetError(this.mtxtUsuarioClientes, "Campo Obrigatório");
            }
            if (mtxtSenhaClientes.Text != metroTextBox1.Text)
            {
                errors.SetError(this.mtxtSenhaClientes, "Os campos não conferem");
                errors.SetError(this.metroTextBox1, "Os campos não conferem");
            }
            else if(mtxtUsuarioClientes.Text != "" && metroTextBox1.Text == mtxtSenhaClientes.Text)
            {
                var userDomain = _appCar.GetUser(userName: mtxtUsuarioClientes.Text);
                if (userDomain.Name == null)
                {
                    User = new Domain.Entities.User(mtxtUsuarioClientes.Text, mtxtSenhaClientes.Text, false);
                    this.Hide();
                    RegisterFinish form = new RegisterFinish(this.StyleManager);
                    form.User = User;
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuário já cadastrado", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }
            }
        }

        private void tooltipo(object sender, System.EventArgs e)
        {
            metroLink1.Enabled = true;
            metroToolTip1.Show("Preencha os campos para prosseguir", metroLink1);
        }

        private void verficiarPreenchimento(object sender, KeyPressEventArgs e)
        {
            
        }

        private void verficiarPreenchimento(object sender, KeyEventArgs e)
        {

            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == mtxtUsuarioClientes.Name)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                mtxtUsuarioClientes.Text = rgx.Replace(mtxtUsuarioClientes.Text, "");

            }
        }
    }
}
