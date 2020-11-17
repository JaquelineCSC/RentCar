using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Client
{
    public partial class NewCard : MetroForm
    {
        public User User { get; set; }
        public DBClient _appClient { get; set; }
        public DBCard _appCard { get; set; }

        public NewCard(MetroStyleManager manager)
        {
            InitializeComponent();
            User = new User();
            _appClient = new DBClient();
            _appCard = new DBCard();
            this.StyleManager = manager;
            Style_Page();
        }

        private void Style_Page()
        {
            OwnerCard.Theme = this.StyleManager.Theme;
            numberCard.Theme = this.StyleManager.Theme;
            CVC.Theme = this.StyleManager.Theme;
            month.Theme = this.StyleManager.Theme;
            year.Theme = this.StyleManager.Theme;
            CvcExplain.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            
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
