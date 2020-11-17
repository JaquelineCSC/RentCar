using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework.Components;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace CarLand.Forms
{
    public partial class Clients : MetroFramework.Forms.MetroForm
    {
        public User User { get; set; }
        public DataRowView RowView { get; set; }
        public DBUser _appUser { get; set; }
        public DBClient _appClient { get; set; }
        public DBCNH _appCNH { get; set; }

        public Clients(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            User = new User();
            _appClient = new DBClient();
            _appCNH = new DBCNH();
            _appUser = new DBUser();
        }

        public void Load_Page()
        {
            metroGrid1.Theme = this.StyleManager.Theme;
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel10.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel4.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            metroLabel7.Theme = this.StyleManager.Theme;
            metroLabel8.Theme = this.StyleManager.Theme;
            metroLabel9.Theme = this.StyleManager.Theme;
            metroLinkSalvar.Theme = this.StyleManager.Theme;
            metroLinkVoltar.Theme = this.StyleManager.Theme;
            metroTabControl1.Theme = this.StyleManager.Theme;
            metroTabPage1.Theme = this.StyleManager.Theme;
            metroTabPage2.Theme = this.StyleManager.Theme;
            rentLink.Theme = this.StyleManager.Theme;
            name.Theme = this.StyleManager.Theme;
            email.Theme = this.StyleManager.Theme;
            user.Theme = this.StyleManager.Theme;
            password.Theme = this.StyleManager.Theme;
            gener.Theme = this.StyleManager.Theme;
            cnh.Theme = this.StyleManager.Theme;
            dateofBirth.Theme = this.StyleManager.Theme;
            phone.Theme = this.StyleManager.Theme;
            validateCNHdate.Theme = this.StyleManager.Theme;
            cpf.Theme = this.StyleManager.Theme;

            metroGrid1.Style = this.StyleManager.Style;
            metroTabControl1.Style = this.StyleManager.Style;
            metroTabPage1.Style = this.StyleManager.Style;
            metroTabPage2.Style = this.StyleManager.Style;
            name.Style = this.StyleManager.Style;
            email.Style = this.StyleManager.Style;
            user.Style = this.StyleManager.Style;
            password.Style = this.StyleManager.Style;
            gener.Style = this.StyleManager.Style;
            cnh.Style = this.StyleManager.Style;
            dateofBirth.Style = this.StyleManager.Style;
            phone.Style = this.StyleManager.Style;
            validateCNHdate.Style = this.StyleManager.Style;
            cpf.Style = this.StyleManager.Style;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'integradoraDataSet.Client'. Você pode movê-la ou removê-la conforme necessário.
            this.clientCNHTableAdapter.Fill(this.client.ClientCNH);

        }

        private void metroLinkVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            error.Tag = 0;
            error.Clear();
            if (name.Text.Length < 3)
            {
                error.SetError(this.name, "O nome tem que ter de 3 a 50 caracteres");
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
            if (phone.Text.Length < 11)
            {
                error.SetError(this.phone, "Insira um número de phone válido");
                error.Tag = 1;
            }
            if (cnh.Text.Length < 11)
            {
                error.SetError(this.cnh, "Insira um número de CNH válido");
                error.Tag = 1;
            }
            if (validateCNHdate.Value < dateofBirth.Value)
            {
                error.SetError(this.validateCNHdate, "Insira uma data válida");
                error.Tag = 1;
            }
            DateTime dateExpected = DateTime.Now.AddYears(-18);
            if (dateofBirth.Value > dateExpected)
            {
                error.SetError(this.dateofBirth, "Você deve ter no mínimo 18 anos para realizar o cadastro");
                error.Tag = 1;
            }
            if ((int)error.Tag == 0)
            {

                Domain.Entities.Client Client = new Domain.Entities.Client()
                {
                    Name = name.Text,
                    Email = email.Text,
                    Phone = long.Parse(phone.Text),
                    Genero = gener.Text,
                    CPF = long.Parse(cpf.Text),
                    DateOfBirth = DateTime.Parse(dateofBirth.Text),
                };
                Domain.Entities.CNH CNH = new CNH()
                {
                    Name = name.Text,
                    Number = long.Parse(cnh.Text),
                    ValidateDate = DateTime.Parse(validateCNHdate.Text),
                };
                Domain.Entities.User User = new User()
                {
                    Name = user.Text,
                    Password = password.Text,
                    isAdmin = false
                };
                try
                {
                    var idCNH = _appCNH.Insert(CNH);
                    var idUser = _appUser.Insert(User);
                    Client.CNH_Id = idCNH;
                    Client.User_Id = idUser;
                    _appClient.Insert(Client);
                    MetroFramework.MetroMessageBox.Show(this, "Cliente Cadastrado com sucesso", "Sucesso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question, 100);
                    this.Close();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Erro inesperado. Por favor entre em contato com seu administrador", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question, 100);
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
        private void rentLink_Click(object sender, EventArgs e)
        {
            if (RowView == null)
            {
                metroGrid1_CellContentClick(metroGrid1, new EventArgs());
            }
            Cars form = new Cars();
            var client = _appClient.GetClientByEmail(RowView["Email"].ToString());
            form.User = User;
            form.Client = client;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                RowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
            }
        }
    }
}
