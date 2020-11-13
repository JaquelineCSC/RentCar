using CarLand.Database;
using CarLand.Domain.Entities;
using System;
using System.Runtime.CompilerServices;

namespace CarLand.Forms
{
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        public DBUser _appUser { get; set; }
        public DBClient _appClient { get; set; }
        public DBCNH _appCNH { get; set; }

        public Clientes()
        {
            InitializeComponent();
            _appClient = new DBClient();
            _appCNH = new DBCNH();
            _appUser = new DBUser();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
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
                MetroFramework.MetroMessageBox.Show(this,"","",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question,100);
                this.Close();
            }
            catch (Exception exp)
            {

            }
        }
    }
}
