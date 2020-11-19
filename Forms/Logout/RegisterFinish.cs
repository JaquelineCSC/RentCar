using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class RegisterFinish : MetroForm
    {
        public User User { get; set; }
        public Domain.Entities.Client Client { get; set; }
        public CNH CNH { get; set; }

        public readonly DBClient _appClient = new DBClient();
        public readonly DBUser _appUser = new DBUser();
        public readonly DBCNH _appCNH = new DBCNH();

        public RegisterFinish(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            User = new User();
        }

        private void Load_Page()
        {
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel10.Theme = this.StyleManager.Theme;
            metroLabel11.Theme = this.StyleManager.Theme;
            metroLabel12.Theme = this.StyleManager.Theme;
            metroLabel13.Theme = this.StyleManager.Theme;
            metroLabel14.Theme = this.StyleManager.Theme;
            metroLabel15.Theme = this.StyleManager.Theme;
            metroLabel16.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel4.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            metroLabel7.Theme = this.StyleManager.Theme;
            metroLabel8.Theme = this.StyleManager.Theme;
            metroLabel9.Theme = this.StyleManager.Theme;
            telefone.Theme = this.StyleManager.Theme;
            nomeTXT.Theme = this.StyleManager.Theme;
            cnh.Theme = this.StyleManager.Theme;
            cpf.Theme = this.StyleManager.Theme;
            dateOfBirth.Theme = this.StyleManager.Theme;
            dateValidateCNH.Theme = this.StyleManager.Theme;
            email.Theme = this.StyleManager.Theme;
            genero.Theme = this.StyleManager.Theme;
            iAgreeCheck.Theme = this.StyleManager.Theme;

            iAgreeCheck.Style = this.StyleManager.Style;
            metroLabel1.Style = this.StyleManager.Style;
            metroLabel10.Style = this.StyleManager.Style;
            metroLabel11.Style = this.StyleManager.Style;
            metroLabel12.Style = this.StyleManager.Style;
            metroLabel13.Style = this.StyleManager.Style;
            metroLabel14.Style = this.StyleManager.Style;
            metroLabel15.Style = this.StyleManager.Style;
            metroLabel16.Style = this.StyleManager.Style;
            metroLabel2.Style = this.StyleManager.Style;
            metroLabel3.Style = this.StyleManager.Style;
            metroLabel4.Style = this.StyleManager.Style;
            metroLabel5.Style = this.StyleManager.Style;
            metroLabel6.Style = this.StyleManager.Style;
            metroLabel7.Style = this.StyleManager.Style;
            metroLabel8.Style = this.StyleManager.Style;
            metroLabel9.Style = this.StyleManager.Style;
            telefone.Style = this.StyleManager.Style;
            nomeTXT.Style = this.StyleManager.Style;
            cnh.Style = this.StyleManager.Style;
            cpf.Style = this.StyleManager.Style;
            dateOfBirth.Style = this.StyleManager.Style;
            dateValidateCNH.Style = this.StyleManager.Style;
            email.Style = this.StyleManager.Style;
            genero.Style = this.StyleManager.Style;

        }

        private void verificarPreenchimentoEmail(object sender, KeyEventArgs e)
        {
            Regex rgx = new Regex("[^\\w\\.@-]");
            email.Text = rgx.Replace(email.Text, "");
        }

        private void verificarPreenchimentoTel(object sender, KeyEventArgs e)
        {
            Regex rgx = new Regex("[^- 0-9 -]");
            telefone.Text = rgx.Replace(telefone.Text, "");
        }

        private void verificarPreenchimentoCPF(object sender, KeyEventArgs e)
        {
            Regex rgx = new Regex("[^- .0-9 -]");
            cpf.Text = rgx.Replace(cpf.Text, "");
        }

        private void verificarPreenchimentoCNH(object sender, KeyEventArgs e)
        {
            Regex rgx = new Regex("[^ 0-9 ]");
            cnh.Text = rgx.Replace(cnh.Text, "");
        }

        private void verificarDados(object sender, EventArgs e)
        {
            if (nomeTXT.Text != "" && email.Text != "" && dateOfBirth.Text != "" && cpf.Text != ""
                && telefone.Text != "" && genero.SelectedIndex != -1 && cnh.Text != "" && dateValidateCNH.Text != ""
                && iAgreeCheck.Checked == true)
            {
                buttonSave.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            error.Tag = 0;
            error.Clear();
            if (nomeTXT.Text.Length < 3)
            {
                error.SetError(this.nomeTXT, "O nome tem que ter de 3 a 50 caracteres");
                error.Tag = 1;
            }
            if (!email.Text.Contains("@") && !email.Text.Contains(".com"))
            {
                error.SetError(this.email, "Insira um endereço de email válido");
                error.Tag = 1;
            }
            if (email.Text.Length < 5)
            {
                error.SetError(this.email, "Insira um endereço de email válido");
                error.Tag = 1;
            }
            if (cpf.Text.Length < 11)
            {
                error.SetError(this.cpf, "Insira um CPF válido");
                error.Tag = 1;
            }
            else
            {
                if (!Check_CPF(cpf.Text))
                {
                    error.SetError(this.cpf, "Insira um CPF válido");
                    error.Tag = 1;
                }
            }
            if (telefone.Text.Length < 11)
            {
                error.SetError(this.telefone, "Insira um número de telefone válido");
                error.Tag = 1;
            }
            if (cnh.Text.Length < 11)
            {
                error.SetError(this.cnh, "Insira um número de CNH válido");
                error.Tag = 1;
            }
            if (dateValidateCNH.Value < dateOfBirth.Value)
            {
                error.SetError(this.dateValidateCNH, "Insira uma data válida");
                error.Tag = 1;
            }
            DateTime dateExpected = DateTime.Now.AddYears(-18);
            if (dateOfBirth.Value > dateExpected)
            {
                error.SetError(this.dateOfBirth, "Você deve ter no mínimo 18 anos para realizar o cadastro");
                error.Tag = 1;
            }
            if ((int)error.Tag == 0)
            {
                Client = new Domain.Entities.Client()
                {
                    Name = nomeTXT.Text,
                    Email = email.Text,
                    CPF = long.Parse(cpf.Text),
                    DateOfBirth = DateTime.Parse(dateOfBirth.Text),
                    Genero = genero.Text,
                    Phone = long.Parse(telefone.Text),
                };

                CNH = new CNH()
                {
                    Name = nomeTXT.Text,
                    Number = long.Parse(cnh.Text),
                    ValidateDate = DateTime.Parse(dateValidateCNH.Text)
                };

                try
                {
                    User.Id = _appUser.Insert(User);
                    Client.CNH_Id = _appCNH.Insert(CNH);
                    Client.User_Id = User.Id;
                    _appClient.Insert(Client);
                    MetroMessageBox.Show(this, "Cliente Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                    Login form = new Login();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Erro Inesperado. Por favor entre em contato com seu administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }
            }
        }

        private bool Check_CPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private void verificarPreenchimentoNome(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            nomeTXT.Text = rgx.Replace(nomeTXT.Text, "");
        }
    }
}
