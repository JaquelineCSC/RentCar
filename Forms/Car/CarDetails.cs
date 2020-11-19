using CarLand.Database;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CarLand.Forms
{
    public partial class CarDetails : MetroForm
    {
        public Domain.Entities.Car Car { get; set; }
        public List<Domain.Entities.Image> Images = new List<Domain.Entities.Image>();

        private readonly DBCar _appCar = new DBCar();
        private readonly DBImage _appImage = new DBImage();

        private int imageCount;
        private int iImage = 0;

        public CarDetails(int carId, MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            Car = _appCar.GetCar(id: carId);
            Images = _appImage.GetImages(Car.Id);
            imageCount = Images.Count;
        }

        private void Load_Page()
        {
            //Theme
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel14.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel4.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            anoTxt.Theme = this.StyleManager.Theme;
            combustivelTxt.Theme = this.StyleManager.Theme;
            corTxt.Theme = this.StyleManager.Theme;
            marcaTxt.Theme = this.StyleManager.Theme;
            modeloTxt.Theme = this.StyleManager.Theme;
            portaTxt.Theme = this.StyleManager.Theme;
        }

        private void DetalhesCarro_Load(object sender, EventArgs e)
        {
            marcaTxt.Text = Car.Branch;
            modeloTxt.Text = Car.Model;
            portaTxt.Text = Car.Doors.ToString();
            anoTxt.Text = Car.Year.ToString();
            corTxt.Text = Car.Color;
            combustivelTxt.Text = Car.Fuel;
            if (Images.Count > 0)
            {
                pictureBox1.Image = (Bitmap)System.Drawing.Image.FromFile(Servers.path + Images[iImage].Path + Images[iImage].Name);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            iImage++;
            if (iImage == imageCount)
                iImage = 0;
            pictureBox1.Image = System.Drawing.Image.FromFile(Servers.path + Images[iImage].Path + Images[iImage].Name);
        }
    }
}
