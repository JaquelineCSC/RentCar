using CarLand.Forms.Admin;
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
    public partial class ListEmployees : MetroFramework.Forms.MetroForm
    {
        public Domain.Entities.User User { get; set; }
        public DataRowView RowView { get; set; }
        public DataRowView NewRowView { get; set; }
        string employeeName;
        public Database.DBEmployee _appEmployee { get; set; }
        public Database.DBUser _appUser { get; set; }

        public ListEmployees()
        {
            InitializeComponent();
            _appEmployee = new Database.DBEmployee();
            _appUser = new Database.DBUser();
            User = new Domain.Entities.User();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employee._Employee);
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
                Funcionarios_Load(this, new EventArgs());
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

        private void metroLink2_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                var currentEmployee = _appEmployee.GetEmployee(User.Id);
                DialogResult result;
                if (currentEmployee.Name == RowView["EmployeeName"].ToString())
                {
                    result = MetroMessageBox.Show(this, $"Tem certeza que deseja excluir seu próprio cadastro? \n Atenção isso resultará na sua desconexão", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);
                }
                else
                {
                    result = MetroMessageBox.Show(this, $"Tem certeza que deseja excluir o funcionário {RowView["EmployeeName"].ToString()}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);
                }
                if (result == DialogResult.Yes)
                {
                    var deleteEmployee = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
                    var employee = _appEmployee.GetEmployee(employeeName: deleteEmployee["EmployeeName"].ToString());
                    _appEmployee.Delete(employee.Name);
                    var user = _appUser.GetUser(id: employee.idUser);
                    _appUser.Delete(user.Name);
                    if (currentEmployee.Name == RowView["EmployeeName"].ToString())
                    {
                        MetroMessageBox.Show(this, "Seu usuário foi deletado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                        Cars form = new Cars();
                        form.ShowDialog();
                        this.ParentForm.Close();
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Funcionário deletado", "", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                        Funcionarios_Load(this, new EventArgs());
                    }
                }
            }
        }

        private void metroGrid1_CellContentClick(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                RowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
                employeeName = RowView["EmployeeName"].ToString();
            }
        }

        private void verificar(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                NewRowView = (DataRowView)metroGrid1.Rows[metroGrid1.SelectedRows[0].Index].DataBoundItem;
                var employee = _appEmployee.GetEmployee(employeeName: employeeName);
                employee.Name = NewRowView["EmployeeName"].ToString();
                _appEmployee.Update(employee);
                Funcionarios_Load(this, new EventArgs());
            }
        }
    }
}
