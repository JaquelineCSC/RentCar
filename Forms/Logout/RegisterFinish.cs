using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
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
        public DBClient _appClient { get; set; }
        public DBUser _appUser { get; set; }
        public DBCNH _appCNH { get; set; }

        public RegisterFinish(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            User = new User();
            _appClient = new DBClient();
            _appCNH = new DBCNH();
            _appClient = new DBClient();
            _appUser = new DBUser();
        }

        private void verificarPreenchimentoEmail(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == email.Name)
            {
                Regex rgx = new Regex("[^\\w\\.@-]");
                email.Text = rgx.Replace(email.Text, "");
            }
        }

        private void verificarPreenchimentoTel(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == telefone.Name)
            {
                Regex rgx = new Regex("[^- 0-9 -]");
                telefone.Text = rgx.Replace(telefone.Text, "");
            }
        }

        private void verificarPreenchimentoCPF(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == cpf.Name)
            {
                Regex rgx = new Regex("[^- .0-9 -]");
                cpf.Text = rgx.Replace(cpf.Text, "");
            }
        }

        private void verificarPreenchimentoCNH(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == cnh.Name)
            {
                Regex rgx = new Regex("[^ 0-9 ]");
                cnh.Text = rgx.Replace(cnh.Text, "");
            }
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

        private void Completar_Cadastro_Load(object sender, EventArgs e)
        {

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
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == nomeTXT.Name)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                nomeTXT.Text = rgx.Replace(nomeTXT.Text, "");
            }
        }
    }
}
