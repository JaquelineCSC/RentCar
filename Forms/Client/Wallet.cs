using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarLand.Forms.Client
{
    public partial class Wallet : MetroForm
    {
        public Domain.Entities.Client Client { get; set; }
        public List<Domain.Entities.Card> Cards { get; set; }

        public readonly Database.DBCard _appCard = new Database.DBCard();

        public Wallet(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Cards = new List<Domain.Entities.Card>();
        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            Cards = _appCard.GetCard(Client.Id);
            var location = card.Location;
            for (int i = 0; i < Cards.Count; i++)
            {
                MetroRadioButton button = new MetroRadioButton();
                button.Name = "Card" + (i + 1);
                button.TabIndex = Cards[i].Id;
                button.Size = new Size(242, card.Size.Height);
                button.Style = MetroColorStyle.Orange;
                button.Theme = this.StyleManager.Theme;
                button.Location = new Point(location.X, location.Y);
                button.Text = "Cartão Final " + (Cards[i].Number).ToString().Substring((Cards[i].Number).ToString().Length - 4);
                if (i + 1 == 3)
                {
                    metroButton1.Visible = false;
                }
                this.Controls.Add(button);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Database.DBUser _appUser = new Database.DBUser();
            NewCard form = new NewCard(this.StyleManager);
            form.User = _appUser.GetUser(id: Client.User_Id);
            form.ShowDialog();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            try
            {
                var card = this.Controls.OfType<MetroRadioButton>().Where(x => x.Checked == true).FirstOrDefault();
                var cardDomain = Cards.Where(x => x.Id == card.TabIndex).FirstOrDefault();
                _appCard.Delete(cardDomain.Number);
                MetroMessageBox.Show(this, "Cartão deletado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
            catch
            {
                MetroMessageBox.Show(this, "Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }
    }
}
