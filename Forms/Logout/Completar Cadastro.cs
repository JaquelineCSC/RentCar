using CarLand.Domain.Entities;
using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Completar_Cadastro : MetroForm
    {
        public Domain.Entities.Client Cl { get; set; }
        public User User { get; set; }
        public DBClient Client { get; set; }

        public Completar_Cadastro(MetroStyleManager manager)
        {
            InitializeComponent();
            User = new User();
            this.StyleManager = manager;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (nomeTXT.Text.Length < 3)
            {
                error.SetError(this.nomeTXT, "Insira um nome válido");
            }
            if (!email.Text.Contains("@"))
            {
                error.SetError(this.email, "Insira um endereço de email válido");
            }
            if (email.Text.Length < 5)
            {
                error.SetError(this.email, "Insira um endereço de email válido");
            }
            if (cpf.Text.Length < 11)
            {
                error.SetError(this.cpf, "Insira um CPF válido");
            }
            if (telefone.Text.Length < 11)
            {
                error.SetError(this.telefone, "Insira um número de telefone válido");
            }
            if (cnh.Text.Length < 11)
            {
                error.SetError(this.cnh, "Insira um número de CNH válido");
            }
            else
            {
                // em produção 
                MetroMessageBox.Show(this, "Cadastro Concluído", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                Carros C1 = new Carros();
                this.Hide();
                C1.ShowDialog();
                this.Close();
            }
        }

        private void verificarPreenchimento(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == nomeTXT.Name)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                nomeTXT.Text = rgx.Replace(nomeTXT.Text, "");
            }
        }

        private void verificarPreenchimentoEmail(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == email.Name)
            {
                Regex rgx = new Regex("[^\\w\\.@-]");
                email.Text = rgx.Replace(email.Text, "");
            }
        }

        private void verificarPreenchimentoTel(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == telefone.Name)
            {
                Regex rgx = new Regex("[^- 0-9 -]");
                telefone.Text = rgx.Replace(telefone.Text, "");
            }
        }

        private void verificarPreenchimentoCPF(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == cpf.Name)
            {
                Regex rgx = new Regex("[^- .0-9 -]");
                cpf.Text = rgx.Replace(cpf.Text, "");
            }
        }

        private void verificarPreenchimentoCNH(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == cnh.Name)
            {
                Regex rgx = new Regex("[^ 0-9 ]");
                cnh.Text = rgx.Replace(cnh.Text, "");
            }
        }

        private void verificarDados(object sender, EventArgs e)
        {
            if (nomeTXT.Text != "" && email.Text != "" && dateOfBirth.Text != "" && cpf.Text != ""
                && telefone.Text != "" && genero.SelectedIndex != -1 && cnh.Text != "" && dateValidateCNH.Text != ""
                && iAgreeCheck.Checked == true)
            {
                buttonSave.Enabled = true;
            }
        }
    }
}
