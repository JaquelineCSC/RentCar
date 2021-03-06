﻿using CarLand.Database;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Carros : MetroForm
    {
        public CarLand.Domain.Entities.User User { get; set; }

        public DBCar _appCar;
        public DBImage _appImage;

        public Carros()
        {
            InitializeComponent();
            _appCar = new DBCar();
            _appImage = new DBImage();
            User = new CarLand.Domain.Entities.User();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Carros_Load(object sender, EventArgs e)
        {
            var cars = _appCar.List();
            var count = cars.Count;
            int x = card.Location.X, y = card.Location.Y, i = 0, linhas, colunas = 0;
            if (count % 3 == 0)
            {
                linhas = cars.Count / 3;
            }
            else
            {
                linhas = cars.Count / 3 + 1;
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
                for (int c = 0; c < colunas && i < cars.Count; c++, i++, x += 318)
                {
                    panel.Controls.Add(addCard(cars[i], i, x, y));
                }
                x = card.Location.X;
                count -= 3;
            }
            if (cars.Count == 0)
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
            newCard.Name = "Card" + i;
            newCard.TabIndex = i + 1;
            newCard.Location = new Point(x, y);
            newCard.Controls.Add(addPictureBox(car.Id));
            newCard.Controls.Add(addTitle(car));
            newCard.Controls.Add(addSubscription(car));
            newCard.Controls.Add(addCifrao(car));
            newCard.Controls.Add(addButton(car.Id));

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
            title.MinimumSize = new Size(280, 0);
            title.FontSize = metroLabel3.FontSize;
            title.FontWeight = MetroLabelWeight.Bold;

            return title;
        }

        public MetroLabel addSubscription(CarLand.Domain.Entities.Car car)
        {
            MetroLabel Preco = new MetroLabel();
            Preco.Text = metroLabel4.Text;
            Preco.Location = metroLabel4.Location;

            return Preco;
        }

        public MetroLabel addCifrao(CarLand.Domain.Entities.Car car)
        {
            MetroLabel Cifrao = new MetroLabel();
            Cifrao.Text = metroLabel5.Text;
            Cifrao.Location = metroLabel5.Location;
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
            button.Click += new System.EventHandler(metroLink2_Click);
            button.Location = metroLink2.Location;

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
            DetalhesCarro form = new DetalhesCarro(link.TabIndex);
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
    }
}
