using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Components;
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
    public partial class Completar_Cadastro : MetroForm
    {
        public User User { get; set; }
        public Domain.Entities.Client Client { get; set; }
        public CNH CNH { get; set; }
        public DBClient _appClient { get; set; }
        public DBUser _appUser { get; set; }
        public DBCNH _appCNH { get; set; }

        public Completar_Cadastro(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            User = new User();
            _appClient = new DBClient();
            _appUser = new DBUser();
            _appCNH = new DBCNH();
        }

        private void verificarPreenchimento(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client = new Domain.Entities.Client()
            {
                Name = name.Text,
                Email = email.Text,
                CPF = long.Parse(cpf.Text),
                DateOfBirth = DateTime.Parse(dateOfBirth.Text),
                Genero = genero.Text,
                Phone = long.Parse(telefone.Text),
            };

            CNH = new CNH()
            {
                Name = name.Text,
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
            catch(Exception exp)
            {
                //ver erro
            }
        }
    }
}
