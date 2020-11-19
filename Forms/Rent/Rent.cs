using CarLand.Database;
using CarLand.Domain.Entities;
using CarLand.Forms.Client;
using MetroFramework;
using MetroFramework.Components;
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

        private int imageCount;
        private int iImage = 0;

        public RadioButton Billet { get; set; }
        public IEnumerable<RadioButton> Card { get; set; }
        public RadioButton Money { get; set; }

        public readonly DBImage _appImage = new DBImage();
        public readonly DBClient _appClient = new DBClient();
        public readonly DBEmployee _appEmployee = new DBEmployee();
        public readonly DBRent _appRent = new DBRent();
        public readonly DBCard _appCard = new DBCard();
        public readonly DBUser _appUser = new DBUser();

        public Rent(Domain.Entities.Car car, AmountCar amount, User user, MetroStyleManager manager, Domain.Entities.Client client = null)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
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

            imageCount = Images.Count;

            List<Card> cards = new List<Card>();
            cards = _appCard.GetCard(FullClient.Client.Id);

            FullClient.Card.AddRange(cards);

            drop_offDate.MinDate = DateTime.Today.AddDays(1).AddSeconds(-10);
            drop_offDate.Value = DateTime.Now.AddDays(1);

            pick_upDate.MinDate = DateTime.Today.AddSeconds(-10);
            pick_upDate.Value = DateTime.Now;

            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(00); _time < time.AddHours(24); _time = _time.AddMinutes(30)) //from 16h to 18h hours
            {
                metroComboBox1.Items.Add(_time.ToShortTimeString());
                metroComboBox2.Items.Add(_time.ToShortTimeString());
            }

            AmountPerDay.Text = amount.Amount.ToString("C2", CultureInfo.CurrentCulture);

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

        private void Load_Page()
        {
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel10.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel7.Theme = this.StyleManager.Theme;
            metroLabel8.Theme = this.StyleManager.Theme;
            metroLabel9.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            if(this.StyleManager.Theme == MetroThemeStyle.Light)
            {
                payments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            name.Theme = this.StyleManager.Theme;
            email.Theme = this.StyleManager.Theme;
            pick_upDate.Theme = this.StyleManager.Theme;
            drop_offDate.Theme = this.StyleManager.Theme;
            metroComboBox2.Theme = this.StyleManager.Theme;
            metroComboBox1.Theme = this.StyleManager.Theme;
        }

        public void Load_Cards()
        {
            if (FullClient.Card.Any())
            {
                int y = 45;
                int abc = 15;
                for (int j = 0; j < 3 && j < FullClient.Card.Count; j++, abc += 15)
                {
                    panelCard.Controls.Add(AddRadioCard(FullClient.Card[j], y));
                    if (j != 2)
                    {
                        panelCard.Size = new System.Drawing.Size(panelCard.Size.Width, panelCard.Size.Height + 10);
                        registerNewCard.Location = new System.Drawing.Point(registerNewCard.Location.X, registerNewCard.Location.Y + abc);
                        payments.Size = new System.Drawing.Size(payments.Size.Width, payments.Size.Height + 10);
                    }
                    y += 23;
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
                carousselImages.BackgroundImage = System.Drawing.Image.FromFile(Servers.path + Images[iImage].Path + Images[iImage].Name);
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

        private void Rent_Load(object sender, EventArgs e)
        {
            FullClient.Card.Clear();
            FullClient.Card.AddRange(_appCard.GetCard(FullClient.Client.Id));
            Load_Cards();
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
            if (drop_offDate.Value < pick_upDate.Value)
            {
                MetroMessageBox.Show(this, "A data de devolução não deve ser menor que a data de retirada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
            else
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

                var hourPickUp = metroComboBox1.SelectedItem.ToString().Split(':');
                pick_upDate.Value = pick_upDate.Value.Add(new TimeSpan(-pick_upDate.Value.Hour, -pick_upDate.Value.Minute, -pick_upDate.Value.Second));
                DateTime pickUp = pick_upDate.Value.Add(new TimeSpan(int.Parse(hourPickUp[0]), int.Parse(hourPickUp[1]), 0));


                var hourDropOff = metroComboBox2.SelectedItem.ToString().Split(':');
                drop_offDate.Value =  drop_offDate.Value.Add(new TimeSpan(-drop_offDate.Value.Hour, -drop_offDate.Value.Minute, -drop_offDate.Value.Second));
                DateTime dropOff = drop_offDate.Value.Add(new TimeSpan(int.Parse(hourDropOff[0]), int.Parse(hourDropOff[1]), 0));

                Domain.Entities.Rent rent = new Domain.Entities.Rent()
                {
                    idCar = Car.Id,
                    idClient = FullClient.Client.Id,
                    PickUpDate = pickUp,
                    DropOffDate = dropOff,
                    Value = double.Parse(value.Text.Replace("R$", "")),
                    PaymentType = paymentType,
                };

                if (rent.PaymentType == PaymentTypeEnum.Card)
                {
                    rent.idCard = payment.TabIndex;
                }

                if (User.isAdmin)
                {
                    var employee = _appEmployee.GetEmployee(User.Id);
                    rent.idEmployee = employee.Id;
                }

                try
                {
                    _appRent.Insert(rent);
                    MetroMessageBox.Show(this, "Aluguel registrado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                    if (User.isAdmin)
                    {
                        FormMain form = new FormMain();
                        form.User = User;
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        FormClient form = new FormClient();
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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NewCard form = new NewCard(this.StyleManager);
            if (User.isAdmin)
                form.User = _appUser.GetUser(id: FullClient.Client.User_Id);
            else
                form.User = User;

            form.ShowDialog();
        }

        private void Set_date(object sender, EventArgs e)
        {
            TimeSpan days = drop_offDate.Value.Date - pick_upDate.Value.Date;
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

        private void changeImage(object sender, EventArgs e)
        {
            iImage++;
            if (iImage == imageCount)
                iImage = 0;
            carousselImages.BackgroundImage = System.Drawing.Image.FromFile(Servers.path + Images[iImage].Path + Images[iImage].Name);

        }
    }
}
