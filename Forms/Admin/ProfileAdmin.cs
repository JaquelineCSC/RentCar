using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CarLand.Forms.Admin
{
    public partial class ProfileAdmin : MetroForm
    {
        public User User { get; set; }
        public readonly DBEmployee _appEmployee = new DBEmployee();
        public readonly DBUser _appUser = new DBUser();

        public ProfileAdmin(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            User = new User();
        }

        public void Load_Page()
        {
            name.Theme = this.StyleManager.Theme;
            password.Theme = this.StyleManager.Theme;
            newPassword.Theme = this.StyleManager.Theme;
            newConfirmPassword.Theme = this.StyleManager.Theme;
            user.Theme = this.StyleManager.Theme;

            metroLinkSalvar.Theme = this.StyleManager.Theme;
            metroLinkVoltar.Theme = this.StyleManager.Theme;

            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            metroLabel7.Theme = this.StyleManager.Theme;

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
