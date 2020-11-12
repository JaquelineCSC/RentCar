using CarLand.Database;
using CarLand.Domain.Entities;
using CarLand.Forms.Client;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CarLand.Forms.Aluguel
{
    public partial class Rent : MetroForm
    {
        public Domain.Entities.ClientCardCNH FullClient { get; set; }
        public User User { get; set; }
        public CarLand.Domain.Entities.Car Car { get; set; }
        public List<Image> Images { get; set; }
        public DBImage _appImage { get; set; }
        public DBClient _appClient { get; set; }
        public RadioButton Billet { get; set; }
        public IEnumerable<RadioButton> Card { get; set; }
        public RadioButton Money { get; set; }

        public Rent(Domain.Entities.Car car, User user)
        {
            InitializeComponent();
            _appImage = new DBImage();
            _appClient = new DBClient();
            Images = new List<Image>();
            User = new User();
            FullClient = new Domain.Entities.ClientCardCNH();
            Car = new Domain.Entities.Car();
            Car = car;
            User = user;
            Images = _appImage.GetImages(car.Id);
            FullClient = _appClient.GetClientCardCNHByUser(User.Id);

            hour_PickUp.MinDate = DateTime.Now;
            hour_PickUp.Value = DateTime.Now;

            drop_offDate.MinDate = DateTime.Now;
            drop_offDate.Value = DateTime.Now;

            hour_DropOff.MinDate = DateTime.Now;
            hour_DropOff.Value = DateTime.Now;

            hour_PickUp.MinDate = DateTime.Now;
            hour_PickUp.Value = DateTime.Now;

            fillFieldsCar();
            Load_Images();
            Load_Cards();
            Set_date(this, new EventArgs());

            Money = panelMoney.Controls.OfType<RadioButton>().FirstOrDefault();
            Billet = panelBillet.Controls.OfType<RadioButton>().FirstOrDefault();
            if (panelMoney.Controls.OfType<RadioButton>().Any())
            {
                Card = panelCard.Controls.OfType<RadioButton>();
                foreach (var item in Card)
                {
                    item.Checked = false;
                }
            }

            Money.Checked = true;
            Billet.Checked = false;
        }

        public void Load_Cards()
        {
            if (FullClient.Card.Any())
            {
                int i = 0, y = 25;
                foreach (var item in FullClient.Card)
                {
                    AddRadioCard(item, y);
                    y += 23;
                    panelCard.Size = new System.Drawing.Size(panelCard.Size.Width, panelCard.Size.Height + 31);
                    payments.Size = new System.Drawing.Size(payments.Size.Width, payments.Size.Height + 28);
                    i++;
                    if(i == 4)
                    {
                        break;
                    }
                }
            }
        }

        private MetroRadioButton AddRadioCard(Card card, int y)
        {
            MetroRadioButton newRadio = new MetroRadioButton();
            newRadio.Name = "Card" + card.Id;
            newRadio.Text = " Cartão XXXX.XXXX.XXXX." + card.Number.ToString().Substring(card.Number.ToString().Length - 4);
            newRadio.Location = new System.Drawing.Point(37, y);

            return newRadio;
        }

        private void Load_Images()
        {
            if (Images.Count > 0)
            {
                var firstImage = Images.FirstOrDefault();
                carousselImages.BackgroundImage = System.Drawing.Image.FromFile(Servers.path + firstImage.Path + firstImage.Name);
                arrow_left.Parent = carousselImages;
                arrow_right.Parent = carousselImages;
            }
            else
            {
                arrow_left.Visible = false;
                arrow_right.Visible = false;
            }
        }

        private void fillFieldsCar()
        {
            name.Text = FullClient.Client.Name;
            email.Text = FullClient.Client.Email;
            branch.Text = Car.Branch;
            model.Text = Car.Model;
            year.Text = Car.Year.ToString();
            color.Text = Car.Color;
            fuel.Text = Car.Fuel;
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {

        }

        private void arrow_left_Click(object sender, EventArgs e)
        {

        }

        private void Rent_Load(object sender, EventArgs e)
        {
            FullClient = _appClient.GetClientCardCNHByUser(User.Id);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cars form = new Cars();
            form.User = User;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NewCard form = new NewCard();
            form.User = User;
            form.ShowDialog();
        }

        private void Set_date(object sender, EventArgs e)
        {
            TimeSpan days = drop_offDate.Value - pick_upDate.Value;
            var daysPrint = days.Days > 0 ? days.Days : 1;
            nDays.Text = daysPrint > 0 ? daysPrint + " Dias" : daysPrint + " Dia";
            daysRight.Text = daysPrint.ToString();
            var amountDay = float.Parse(AmountPerDay.Text.Replace("R$", ""));
            var total = (amountDay * daysPrint).ToString("C", CultureInfo.CurrentCulture);
            metroLabel22.Text = total;
        }

        private void RadioButtonSelected(object sender, EventArgs e)
        {
            MetroRadioButton radio = (MetroRadioButton)sender;

            if (radio.Name.Contains("money"))
            {
                Money.Checked = true;
                Billet.Checked = false;
                if (Card.Any())
                {
                    foreach (var item in Card)
                    {
                        item.Checked = false;
                    }
                }
            }
            else if (radio.Name.Contains("billet"))
            {
                Money.Checked = false;
                Billet.Checked = true;
                if (Card.Any())
                {
                    foreach (var item in Card)
                    {
                        item.Checked = false;
                    }
                }
            }
            else
            {
                Money.Checked = false;
                Billet.Checked = false;
            }
        }
    }
}
