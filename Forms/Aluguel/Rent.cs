using CarLand.Database;
using CarLand.Domain.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLand.Forms.Aluguel
{
    public partial class Rent : MetroForm
    {
        public User User { get; set; }
        public CarLand.Domain.Entities.Car Car { get; set; }
        public List<Image> Images { get; set; }
        public DBImage _appImage { get; set; }

        public Rent(Domain.Entities.Car car)
        {
            InitializeComponent();
            _appImage = new DBImage();
            User = new User();
            Car = new Domain.Entities.Car();
            Car = car;
            Images = new List<Image>();
            Images = _appImage.GetImages(car.Id);
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {

        }

        private void arrow_left_Click(object sender, EventArgs e)
        {

        }

        private void Rent_Load(object sender, EventArgs e)
        {
            if(Images.Count > 0)
            {
                var firstImage = Images.FirstOrDefault();
                carousselImages.BackgroundImage = System.Drawing.Image.FromFile(Servers.path + firstImage.Path + firstImage.Name);
                arrow_left.Parent = carousselImages;
                arrow_right.Parent = carousselImages;
            }
        }
    }
}
