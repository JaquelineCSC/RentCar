using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class ListEmployees : MetroForm
    {
        public Domain.Entities.User User { get; set; }
        private string employeeName;
        
        public DataRowView RowView;
        public DataRowView NewRowView;
        
        public readonly Database.DBEmployee _appEmployee = new Database.DBEmployee();
        public readonly Database.DBUser _appUser = new Database.DBUser();

        public ListEmployees(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Style_Page();
            User = new Domain.Entities.User();
        }

        public void Style_Page()
        {
            //Theme
            metroTabControl1.Theme = this.StyleManager.Theme;
            metroGrid1.Theme = this.StyleManager.Theme;
            user.Theme = this.StyleManager.Theme;
            password.Theme = this.StyleManager.Theme;
            name.Theme = this.StyleManager.Theme;
            metroTabPage1.Theme = this.StyleManager.Theme;
            metroTabPage2.Theme = this.StyleManager.Theme;
            metroLink2.Theme = this.StyleManager.Theme;
            metroLinkSalvar.Theme = this.StyleManager.Theme;
            metroLinkVoltar.Theme = this.StyleManager.Theme;
            metroLabel11.Theme = this.StyleManager.Theme;
            metroLabel12.Theme = this.StyleManager.Theme;
            metroLabel13.Theme = this.StyleManager.Theme;


            //Style
            metroTabControl1.Style = this.StyleManager.Style;
            metroGrid1.Style = this.StyleManager.Style;
            user.Style = this.StyleManager.Style;
            password.Style = this.StyleManager.Style;
            name.Style = this.StyleManager.Style;
            metroTabPage1.Style = this.StyleManager.Style;
            metroTabPage2.Style = this.StyleManager.Style;
            metroLinkSalvar.Style= this.StyleManager.Style;
            metroLinkVoltar.Style = this.StyleManager.Style;
            metroLabel11.Style = this.StyleManager.Style;
            metroLabel12.Style = this.StyleManager.Style;
            metroLabel13.Style = this.StyleManager.Style;

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employee._Employee);
        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            Domain.Entities.Employee Employee = new Domain.Entities.Employee();
            Domain.Entities.User User = new Domain.Entities.User();
            
            Employee.Name = name.Text;
            User.Name = user.Text;
            User.isAdmin = true;
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
                var currentEmployee = _appEmployee.GetEmployee(idUser: User.Id);
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
