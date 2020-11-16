using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Client
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        public User User { get; set; }
        public DBClient _appClient { get; set; }
        public DBCNH _appCNH { get; set; }
        public ClientCardCNH FullClient { get; set; }

        public Profile(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            User = new User();
            _appClient = new DBClient();
            _appCNH = new DBCNH();
            FullClient = new ClientCardCNH();
        }

        public void Load_Page()
        {
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel4.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            metroLabel7.Theme = this.StyleManager.Theme;
            metroLabel8.Theme = this.StyleManager.Theme;
            metroLabel9.Theme = this.StyleManager.Theme;
            
            name.Theme = this.StyleManager.Theme;
            email.Theme = this.StyleManager.Theme;
            dateOfBirth.Theme = this.StyleManager.Theme;
            dateValidateCNH.Theme = this.StyleManager.Theme;
            cpf.Theme = this.StyleManager.Theme;
            cnh.Theme = this.StyleManager.Theme;
            phone.Theme = this.StyleManager.Theme;
            gener.Theme = this.StyleManager.Theme;

            metroLinkSalvar.Theme = this.StyleManager.Theme;
            metroLinkVoltar.Theme = this.StyleManager.Theme;

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            FullClient =_appClient.GetClientCNHByUser(User.Id);
            if(FullClient != null)
            {
                name.Text = FullClient.Client.Name;
                email.Text = FullClient.Client.Email;
                dateOfBirth.Text = FullClient.Client.DateOfBirth.ToString("dd/MM/yyyy");
                cpf.Text = FullClient.Client.CPF.ToString();
                phone.Text = FullClient.Client.Phone.ToString();
                gener.SelectedItem = FullClient.Client.Genero;
                cnh.Text = FullClient.CNH.Number.ToString();
                dateValidateCNH.Text = FullClient.CNH.ValidateDate.ToString("dd/MM/yyyy");
            }
            else
            {
                MetroMessageBox.Show(this, "Erro inesperado. Por favor entre em contato com seu administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                this.Close();
            }
        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FullClient.Client.Name = name.Text;
                FullClient.Client.Email = email.Text;
                FullClient.Client.DateOfBirth = DateTime.Parse(dateOfBirth.Text);
                FullClient.Client.CPF = long.Parse(cpf.Text);
                FullClient.Client.Phone = long.Parse(phone.Text);
                FullClient.Client.Genero = gener.SelectedItem.ToString();
                FullClient.CNH.Name = FullClient.Client.Name;
                FullClient.CNH.Number = long.Parse(cnh.Text);
                FullClient.CNH.ValidateDate = DateTime.Parse(dateValidateCNH.Text);
                _appClient.Update(FullClient.Client);
                _appCNH.Update(FullClient.CNH);
                MetroMessageBox.Show(this, "Perfil atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
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
