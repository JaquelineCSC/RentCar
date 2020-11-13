using CarLand.Database;
using CarLand.Domain.Entities;
using CarLand.Forms.Client;
using MetroFramework;
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
        public DBRent _appRent { get; set; }
        public DBCard _appCard { get; set; }
        public DBUser _appUser { get; set; }
        public RadioButton Billet { get; set; }
        public IEnumerable<RadioButton> Card { get; set; }
        public RadioButton Money { get; set; }

        public Rent(Domain.Entities.Car car, User user, Domain.Entities.Client client = null)
        {
            InitializeComponent();

            _appImage = new DBImage();
            _appClient = new DBClient();
            _appRent = new DBRent();
            _appCard = new DBCard();
            _appUser = new DBUser();

            Images = new List<Image>();
            User = new User();
            FullClient = new Domain.Entities.ClientCardCNH();
            Car = new Domain.Entities.Car();

            Car = car;
            User = user;

            Images = _appImage.GetImages(car.Id);
            if (User.isAdmin)
                FullClient = _appClient.GetClientCNHByUser(client.User_Id);
            else
                FullClient = _appClient.GetClientCNHByUser(User.Id);

            List<Card> cards = new List<Card>();
            cards = _appCard.GetCard(FullClient.Client.Id);

            FullClient.Card.AddRange(cards);

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

            Money = money;
            Billet = billet;
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
                int i = 0, y = 45;
                foreach (var item in FullClient.Card)
                {
                    panelCard.Controls.Add(AddRadioCard(item, y));
                    y += 23;
                    panelCard.Size = new System.Drawing.Size(panelCard.Size.Width, panelCard.Size.Height + 31);
                    registerNewCard.Location = new System.Drawing.Point(registerNewCard.Location.X, registerNewCard.Location.Y + 29);
                    payments.Size = new System.Drawing.Size(payments.Size.Width, payments.Size.Height + 28);
                    i++;
                    if (i == 4)
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
            newRadio.Text = " Cartão Final " + card.Number.ToString().Substring(card.Number.ToString().Length - 4);
            newRadio.Location = new System.Drawing.Point(19, y);
            newRadio.TabIndex = card.Id;
            newRadio.Size = new System.Drawing.Size(300, 15);
            newRadio.Style = MetroFramework.MetroColorStyle.Orange;
            newRadio.Click += new EventHandler(RadioButtonSelected);

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
            MetroRadioButton payment = new MetroRadioButton();
            PaymentTypeEnum paymentType;
            if (billet.Checked)
            {
                payment = billet;
                paymentType = PaymentTypeEnum.Billet;
            }
            else if (money.Checked)
            {
                payment = money;
                paymentType = PaymentTypeEnum.Money;
            }
            else
            {
                payment = Card.OfType<MetroRadioButton>().Where(x => x.Checked == true).FirstOrDefault();
                paymentType = PaymentTypeEnum.Card;
            }


            Domain.Entities.Rent rent = new Domain.Entities.Rent()
            {
                idCar = Car.Id,
                idClient = FullClient.Client.Id,
                PickUpDate = pick_upDate.Value,
                DropOffDate = drop_offDate.Value,
                Value = double.Parse(value.Text.Replace("R$", "")),
                PaymentType = paymentType,
            };

            if (rent.PaymentType == PaymentTypeEnum.Card)
            {
                rent.idCard = payment.TabIndex;
            }

            try
            {
                _appRent.Insert(rent);
                MetroMessageBox.Show(this, "Aluguel registrado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                if (User.isAdmin)
                {
                    FrmPrincipal form = new FrmPrincipal();
                    form.User = User;
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    FrmUsuario form = new FrmUsuario();
                    form.User = User;
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Erro Inesperado. Por favor entre em contato com seu administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NewCard form = new NewCard();
            if (User.isAdmin)
                form.User = _appUser.GetUser(id: FullClient.Client.User_Id);
            else
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
            value.Text = total;
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
                    Card.OfType<RadioButton>().ToList().ForEach(x => x.Checked = false);
                }
            }
            else if (radio.Name.Contains("billet"))
            {
                Money.Checked = false;
                Billet.Checked = true;
                if (Card.Any())
                {
                    Card.OfType<RadioButton>().ToList().ForEach(x => x.Checked = false);
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
