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
            // TODO: esta linha de código carrega dados na tabela 'listaCliente.ClientCNH'. Você pode movê-la ou removê-la conforme necessário.
            this.clientCNHTableAdapter1.Fill(this.listaCliente.ClientCNH);
            

        }

        private void metroLinkVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
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
