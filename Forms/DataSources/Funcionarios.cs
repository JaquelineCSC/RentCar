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
        public Funcionarios()
        {
            InitializeComponent();
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
    }
}
