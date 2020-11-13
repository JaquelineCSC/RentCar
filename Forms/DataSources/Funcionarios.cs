using MetroFramework;
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
    public partial class Funcionarios : MetroFramework.Forms.MetroForm
    {
        public Database.DBEmployee _appEmployee { get; set; }
        public Database.DBUser _appUser { get; set; }

        public Funcionarios()
        {
            InitializeComponent();
            _appEmployee = new Database.DBEmployee();
            _appUser = new Database.DBUser();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee._Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employee._Employee);
            // TODO: esta linha de código carrega dados na tabela 'listFuncionarios.Employee'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            Domain.Entities.Employee Employee = new Domain.Entities.Employee();
            Employee.Name = name.Text;
            Domain.Entities.User User = new Domain.Entities.User();
            User.Name = user.Text;
            User.Password = password.Text;
            try
            {
                Employee.idUser = _appUser.Insert(User);
                _appEmployee.Insert(Employee);
                MetroMessageBox.Show(this, "Administrador cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch
            {
                MetroMessageBox.Show(this, "Erro inesperado. Por favor entre em contato com seu administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroLinkVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
