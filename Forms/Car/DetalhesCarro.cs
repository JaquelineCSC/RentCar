using CarLand.Database;
using CarLand.Domain.Entities;
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

namespace CarLand.Forms
{
    public partial class DetalhesCarro : MetroForm
    {
        private readonly DBCar _appCar = new DBCar();
        private readonly DBImage _appImage = new DBImage();
        public CarLand.Domain.Entities.Car Car { get; set; }
        public List<CarLand.Domain.Entities.Image> Images { get; set; }
        int i = 0;

        public DetalhesCarro(int carId)
        {
            InitializeComponent();
            Car = _appCar.GetCar(carId);
            Images = _appImage.GetImages(Car.Id);
        }

        private void DetalhesCarro_Load(object sender, EventArgs e)
        {
            marcaTxt.Text = Car.Branch;
            modeloTxt.Text = Car.Model;
            portaTxt.Text = Car.Doors.ToString();
            anoTxt.Text = Car.Year.ToString();
            corTxt.Text = Car.Color;
            combustivelTxt.Text = Car.Fuel;
            if(Images.Count > 0)
            {
                pictureBox1.Image = (Bitmap)System.Drawing.Image.FromFile(Images[i].Path + Images[i].Name);
            }
        }

    }
}
