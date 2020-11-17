using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;


namespace CarLand.Forms.Client
{
    public partial class Wallet : MetroFramework.Forms.MetroForm
    {
        public Domain.Entities.Client Client { get; set; }

        public Wallet(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Style_Page();
        }

        private void Style_Page()
        {
            card.Theme = this.StyleManager.Theme;
        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            Database.DBCard _appCard = new Database.DBCard();
            var cards = _appCard.GetCard(Client.Id);

        }
    }
}
