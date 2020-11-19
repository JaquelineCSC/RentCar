using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarLand.Forms.Client
{
    public partial class NewCard : MetroForm
    {
        public User User { get; set; }

        public readonly DBClient _appClient = new DBClient();
        public readonly DBCard _appCard = new DBCard();

        public NewCard(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            User = new User();
        }

        private void Load_Page()
        {
            OwnerCard.Theme = this.StyleManager.Theme;
            CVC.Theme = this.StyleManager.Theme;
            CvcExplain.Theme = this.StyleManager.Theme;
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            month.Theme = this.StyleManager.Theme;
            numberCard.Theme = this.StyleManager.Theme;
            year.Theme = this.StyleManager.Theme;
        }

        private void NewCard_Load(object sender, EventArgs e)
        {
            CvcExplain.Location = new Point(89, 178);
            CvcExplain.BringToFront();
        }

        private void whatIsCVC(object sender, EventArgs e)
        {
            if (CvcExplain.Visible)
                CvcExplain.Visible = false;
            else
                CvcExplain.Visible = true;
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void register_Click(object sender, EventArgs e)
        {
            error.Tag = 0;
            error.Clear();
            if (CVC.Text.Length < 3)
            {
                error.SetError(CVC, "CVC contém 3 números");
                error.Tag = 1;
            }
            if (month.Text == "")
            {
                error.SetError(month, "Campo obrigatório");
                error.Tag = 1;
            }
            if (OwnerCard.Text == "")
            {
                error.SetError(OwnerCard, "Campo obrigatório");
                error.Tag = 1;
            }
            if (numberCard.Text.Length < 16)
            {
                error.SetError(numberCard, "Cartão Invalido");
                error.Tag = 1;
            }
            if (year.Text == "")
            {
                error.SetError(year, "Campo obrigatório");
                error.Tag = 1;
            }

            if ((int)error.Tag == 0)
            {
                var owner = OwnerCard.Text;
                var number = numberCard.Text;
                var cvc = CVC.Text;
                var MM = month.Text;
                var yyyy = year.Text;
                var dateValidate = DateTime.Parse($"01/{MM}/{yyyy}");
                var client = _appClient.GetClientByUser(User.Id);
                
                Card card = new Card()
                {
                    Name = owner,
                    CVC = int.Parse(cvc),
                    Number = long.Parse(number),
                    ValidateDate = dateValidate,
                    idClient = client.Id,
                };

                try
                {
                    _appCard.Insert(card);
                    MetroMessageBox.Show(this, "Cartão cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                    this.Close();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Erro inesperado. Por favor entre em contato com seu administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }
            }

        }
    }
}
