using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
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

        public Profile()
        {
            InitializeComponent();
            User = new User();
            _appClient = new DBClient();
            _appCNH = new DBCNH();
            FullClient = new ClientCardCNH();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            FullClient =_appClient.GetClientCardCNHByUser(User.Id);
            if(FullClient != null)
            {
                name.Text = FullClient.Client.Name;
                email.Text = FullClient.Client.Email;
                dateOfBirth.Text = string.Format(CultureInfo.CurrentCulture, "dd/MM/yyyy", FullClient.Client.DateOfBirth);
                cpf.Text = FullClient.Client.CPF.ToString();
                phone.Text = FullClient.Client.Phone.ToString();
                gener.SelectedText = FullClient.Client.Genero;
                cnh.Text = FullClient.CNH.Number.ToString();
                dateValidateCNH.Text = string.Format(CultureInfo.CurrentCulture, "dd/MM/yyyy", FullClient.CNH.ValidateDate);
            }
            else
            {
                MetroMessageBox.Show(this, "Erro ao abrir perfil por favor tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
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
                FullClient.Client.Genero = gener.SelectedValue.ToString();
                FullClient.CNH.Number = int.Parse(cnh.Text);
                FullClient.CNH.ValidateDate = DateTime.Parse(dateValidateCNH.Text);
                _appClient.Update(FullClient.Client);
                _appCNH.Update(FullClient.CNH);
                MetroMessageBox.Show(this, "Perfil atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch (Exception exp)
            {
                MetroMessageBox.Show(this, "Ocorreu erro inesperado. Por favor entre em contato com seu administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }
    }
}
