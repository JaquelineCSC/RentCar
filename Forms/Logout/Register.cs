using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Register : MetroForm
    {
        public Domain.Entities.User User { get; set; }
        
        public readonly DBUser _appCar = new DBUser();

        public Register(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
        }

        private void Load_Page()
        {
            mtxtUsuarioClientes.Theme = this.StyleManager.Theme;
            mtxtSenhaClientes.Theme = this.StyleManager.Theme;
            metroTextBox1.Theme = this.StyleManager.Theme;
            metroLink1.Theme = this.StyleManager.Theme;

            mtxtUsuarioClientes.Style = this.StyleManager.Style;
            mtxtSenhaClientes.Style = this.StyleManager.Style;
            metroTextBox1.Style = this.StyleManager.Style;
        }

        private void verficiarPreenchimento(object sender, System.EventArgs e)
        {
            if (mtxtUsuarioClientes.Text != "" && mtxtSenhaClientes.Text != "" && metroTextBox1.Text != "")
                metroLink1.Enabled = true;
        }

        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            errors.Clear();
            errors.Tag = 0;
            if (mtxtSenhaClientes.Text == "")
            {
                errors.SetError(this.mtxtSenhaClientes, "Campo Obrigatório");
                errors.Tag = 1;
            }
            if (mtxtSenhaClientes.Text.Length < 8)
            {
                errors.SetError(this.mtxtSenhaClientes, "Insira pelo menos 8 caracteres");
                errors.Tag = 1;
            }
            if (mtxtSenhaClientes.Text.Length > 16)
            {
                errors.SetError(this.mtxtSenhaClientes, "Insira no máximo 16 caracteres");
                errors.Tag = 1;
            }
            if (metroTextBox1.Text == "")
            {
                errors.SetError(this.metroTextBox1, "Campo Obrigatório");
                errors.Tag = 1;
            }
            if (mtxtUsuarioClientes.Text == "")
            {
                errors.SetError(this.mtxtUsuarioClientes, "Campo Obrigatório");
                errors.Tag = 1;
            }
            if (mtxtSenhaClientes.Text != metroTextBox1.Text)
            {
                errors.SetError(this.mtxtSenhaClientes, "Os campos não conferem");
                errors.SetError(this.metroTextBox1, "Os campos não conferem");
                errors.Tag = 1;
            }
            
            if((int)errors.Tag == 0)
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
