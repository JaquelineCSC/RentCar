using MetroFramework.Controls;
using MetroFramework.Forms;
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
    public partial class Wallet : MetroForm
    {
        public Domain.Entities.Client Client { get; set; }

        public Wallet()
        {
            InitializeComponent();
        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            Database.DBCard _appCard = new Database.DBCard();
            var cards = _appCard.GetCard(Client.Id);
            for(int i=0, y = 0; i < cards.Count; i++, y += 28)
            {
                MetroRadioButton button = new MetroRadioButton();
                button.Name = "Card" + (i + 1);
                button.TabIndex = i + 1;
                button.Location = new Point(card.Location.X, card.Location.Y + y);
                button.Text = "Cartão Final " + (cards[i].Number);
            }
        }
    }
}
