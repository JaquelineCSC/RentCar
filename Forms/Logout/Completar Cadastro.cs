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
        public Client Client { get; set; }
        public DBClient _appClient { get; set; }
        public DBUser _appUser { get; set; }

        public Completar_Cadastro(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            User = new User();
            _appClient = new DBClient();
            _appUser = new DBUser();
        }

        private void verificarPreenchimento(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client = new Client()
            {
                Name = name.Text,
                Email = email.Text,
                CNH = int.Parse(cnh.Text),
                CPF = int.Parse(cpf.Text),
                DateOfBirth = DateTime.Parse(dateOfBirth.Text),
                Genero = genero.Text,
                Phone = int.Parse(telefone.Text),
            };

            try
            {
                User.Id = _appUser.Insert(User);
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
