using CarLand.Database;
using CarLand.Forms.Admin;
using CarLand.Forms.Aluguel;
using CarLand.Forms.Client;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Cars : MetroForm
    {
        public CarLand.Domain.Entities.User User = new Domain.Entities.User();
        public Domain.Entities.Client Client = new Domain.Entities.Client();
        public List<Domain.Entities.Car> ListCars = new List<Domain.Entities.Car>();

        public DBCar _appCar = new DBCar();
        public DBImage _appImage = new DBImage();
        public DBAmount _appAmount = new DBAmount();

        public Cars(MetroStyleManager manager = null)
        {
            InitializeComponent();
            if (manager != null)
                this.StyleManager = manager;

            this.StyleManager = metroStyleManager1;

            if (int.Parse(Properties.Settings.Default["Theme"].ToString()) == 0)
            {
                StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                StyleManager.Theme = MetroThemeStyle.Light;
            }
            Load_Page();
        }

        public void Load_Page()
        {
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            record_not_found.Theme = this.StyleManager.Theme;
            carName.Theme = this.StyleManager.Theme;
            dateCar.Theme = this.StyleManager.Theme;
            panel.Theme = this.StyleManager.Theme;
            metroPanel2.Theme = this.StyleManager.Theme;
            if(this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                card.Theme = MetroThemeStyle.Light;
                metroLabel3.Theme = MetroThemeStyle.Light;
                metroLabel4.Theme = MetroThemeStyle.Light;
                metroLabel5.Theme = MetroThemeStyle.Light;

                metroPanel3.Theme = MetroThemeStyle.Light;
                metroLabel6.Theme = MetroThemeStyle.Light;
                metroLabel7.Theme = MetroThemeStyle.Light;
                metroLabel8.Theme = MetroThemeStyle.Light;
            }
            else
            {
                card.Theme = MetroThemeStyle.Dark;
                metroLabel3.Theme = MetroThemeStyle.Dark;
                metroLabel4.Theme = MetroThemeStyle.Dark;
                metroLabel5.Theme = MetroThemeStyle.Dark;
                metroPanel3.Theme = MetroThemeStyle.Dark;
                metroLabel6.Theme = MetroThemeStyle.Dark;
                metroLabel7.Theme = MetroThemeStyle.Dark;
                metroLabel8.Theme = MetroThemeStyle.Dark;
            }

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Carros_Load(object sender, EventArgs e)
        {
            var cardsDeleted = panel.Controls.OfType<MetroPanel>().Where(card => card.Name != "card").ToList();
            cardsDeleted.ForEach(delegate(MetroPanel item) {
                panel.Controls.Remove(item);
            });
            Filter();
            var count = ListCars.Count;
            int x = card.Location.X, y = card.Location.Y, i = 0, linhas, colunas = 0;
            if (count % 3 == 0)
            {
                linhas = ListCars.Count / 3;
            }
            else
            {
                linhas = ListCars.Count / 3 + 1;
            }
            for (int l = 0; l < linhas; l++, i++, y += 333)
            {
                if (count > 3)
                {
                    colunas = 3;
                }
                else
                {
                    colunas = count + 1;
                }
                for (int c = 0; c < colunas && i < ListCars.Count; c++, i++, x += 318)
                {
                    panel.Controls.Add(addCard(ListCars[i], i, x, y));
                }
                x = card.Location.X;
                count -= 3;
            }
            if (ListCars.Count == 0)
            {
                record_not_found.Visible = true;
            }
            else
            {
                record_not_found.Visible = false;
            }
            if (User.Id == 0)
            {
                logout.Visible = false;
                login.Visible = true;
            }
            else
            {
                logout.Visible = true;
                login.Visible = false;
                email.Text = User.Name;
            }
        }

        public MetroPanel addCard(Domain.Entities.Car car, int i, int x, int y)
        {
            MetroPanel newCard = new MetroPanel();
            newCard.Size = card.Size;
            newCard.Theme = card.Theme;
            newCard.Name = "Card" + i;
            newCard.TabIndex = i + 1;
            newCard.Location = new Point(x, y);
            newCard.Controls.Add(addPictureBox(car.Id));
            newCard.Controls.Add(addTitle(car));
            newCard.Controls.Add(addSubscription(car));
            newCard.Controls.Add(addCifrao(car));
            newCard.Controls.Add(addButton(car.Id));
            newCard.Controls.Add(addRentButton(car.Id));
            if (User.Id != 0 && !User.isAdmin || Client.Id != 0)
            {
                var rentButton = newCard.Controls.OfType<MetroLink>().Where(btn => btn.Text == "Alugar");
                foreach (var item in rentButton)
                {
                    item.Visible = true;
                }
            }
            return newCard;
        }

        public PictureBox addPictureBox(int id)
        {
            var picture = (_appImage.GetImages(id)).FirstOrDefault();
            PictureBox pic = new PictureBox();
            pic.Size = pictureBox2.Size;
            pic.Location = new Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            if (picture == null)
            {
                pic.Image = pictureBox2.Image;
            }
            else
            {
                pic.Image = Image.FromFile(Path.Combine(Servers.path + picture.Path + picture.Name));
                pic.Name = picture.Name;
            }
            return pic;
        }

        public MetroLabel addTitle(CarLand.Domain.Entities.Car car)
        {
            MetroLabel title = new MetroLabel();

            title.Text = $"{car.Branch} {car.Model} {car.Year}";
            title.Location = metroLabel3.Location;
            title.Name = "Title" + car.Id;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.MinimumSize = new Size(280, 0);
            title.Theme = metroLabel3.Theme;
            title.MinimumSize = new Size(280, 0);
            title.FontSize = metroLabel3.FontSize;
            title.FontWeight = MetroLabelWeight.Bold;

            return title;
        }

        public MetroLabel addSubscription(CarLand.Domain.Entities.Car car)
        {
            MetroLabel Preco = new MetroLabel();
            Preco.Text = metroLabel4.Text;
            Preco.Theme = metroLabel4.Theme;

            Preco.Location = metroLabel4.Location;

            return Preco;
        }

        public MetroLabel addCifrao(CarLand.Domain.Entities.Car car)
        {
            var amount = _appAmount.GetAmount(car.Id);
            MetroLabel Cifrao = new MetroLabel();
            Cifrao.Text = $"R$ {amount.Amount}";
            Cifrao.Location = metroLabel5.Location;
            Cifrao.Theme = metroLabel5.Theme;
            Cifrao.FontSize = metroLabel5.FontSize;
            Cifrao.FontWeight = MetroLabelWeight.Bold;

            return Cifrao;

        }

        public MetroLink addButton(int i)
        {
            MetroLink button = new MetroLink();
            button.Size = metroLink2.Size;
            button.BackColor = Color.Gold;
            button.UseCustomBackColor = true;
            button.Text = "Detalhes";
            button.TabIndex = i;
            button.UseCustomForeColor = true;
            button.ForeColor = Color.Black;
            button.Click += new System.EventHandler(metroLink2_Click);
            button.Location = metroLink2.Location;

            return button;
        }

        public MetroLink addRentButton(int i)
        {
            MetroLink button = new MetroLink();
            button.Size = metroLink3.Size;
            button.BackColor = Color.LimeGreen;
            button.UseCustomBackColor = true;
            button.Text = "Alugar";
            button.TabIndex = i;
            button.Click += new System.EventHandler(metroLink3_Click);
            button.UseCustomForeColor = true;
            button.ForeColor = Color.Black;
            button.Location = metroLink3.Location;
            button.Visible = false;

            return button;
        }

        private void metroLinkLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void habilitarToolTIpo(object sender, EventArgs e)
        {
            metroToolTip1.Show("Login", metroLinkLogout);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            MetroLink link = (MetroLink)sender;
            CarDetails form = new CarDetails(link.TabIndex, this.StyleManager);
            form.ShowDialog();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            User.Clear();
            metroPanel3.Visible = false;
            logout.Visible = false;
            login.Visible = true;
        }

        private void metroPanel5_Paint(object sender, EventArgs e)
        {
            if (metroPanel3.Visible)
            {
                metroPanel3.Visible = false;
            }
            else
            {
                metroPanel3.Visible = true;
            }
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            MetroLink link = (MetroLink)sender;
            var car = _appCar.GetCar(id: link.TabIndex);
            var amount = _appAmount.GetAmount(car.Id);
            Rent form = new Rent(car, amount, User, this.StyleManager, Client);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {
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

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            if (User.isAdmin)
            {
                ProfileAdmin form = new ProfileAdmin(this.StyleManager);
                form.User = User;
                form.ShowDialog();
            }
            else
            {
                Profile form = new Profile(this.StyleManager);
                form.User = User;
                form.ShowDialog();
            }
        }

        public void Filter()
        {
            var car = carName.Text;
            var date = dateCar.Text;

             ListCars.Clear();
            metroPanel3.Controls.OfType<MetroPanel>();
             ListCars = _appCar.List(car, date);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Carros_Load(this, new EventArgs());
        }
    }
}
