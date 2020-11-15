using CarLand.Database;
using CarLand.Domain.Entities;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace CarLand.Forms
{
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        public User User { get; set; }
        public DataRowView RowView { get; set; }
        public DBUser _appUser { get; set; }
        public DBClient _appClient { get; set; }
        public DBCNH _appCNH { get; set; }

        public Clientes()
        {
            InitializeComponent();
            User = new User();
            _appClient = new DBClient();
            _appCNH = new DBCNH();
            _appUser = new DBUser();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'integradoraDataSet.Client'. Você pode movê-la ou removê-la conforme necessário.
            this.clientTableAdapter.Fill(this.integradoraDataSet.Client);
            // TODO: This line of code loads data into the 'client.ClientCNH' table. You can move, or remove it, as needed.
            this.clientCNHTableAdapter.Fill(this.client.ClientCNH);
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
