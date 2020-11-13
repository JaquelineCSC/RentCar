using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
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

namespace CarLand.Forms.Admin
{
    public partial class ProfileAdmin : MetroForm
    {
        public User User { get; set; }
        public DBEmployee _appEmployee { get; set; }
        public DBUser _appUser { get; set; }
        public ProfileAdmin()
        {
            InitializeComponent();
            User = new User();
            _appUser = new DBUser();
            _appEmployee = new DBEmployee();
        }

        private void metroLinkVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            User.Name = user.Text;
            User.Password = password.Text;
            var employee = _appEmployee.GetEmployee(User.Id);
            if(employee != null)
            {
                employee.Name = name.Text;
                _appEmployee.Update(employee);
                _appUser.Update(User);
                MetroMessageBox.Show(this, "Atualização Concluída", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            else
            {
                MetroMessageBox.Show(this, "Funcionário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void ProfileAdmin_Load(object sender, EventArgs e)
        {
            Employee employee = _appEmployee.GetEmployee(User.Id);
            name.Text = employee.Name;
            user.Text = User.Name;
        }
    }
}
