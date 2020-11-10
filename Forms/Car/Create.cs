using CarLand.Database;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CarLand.Forms.Car
{
    public partial class Create : MetroForm
    {

        public DBImage _appImage { get; set; }
        public DBCar _appCar { get; set; }
        public CarLand.Domain.Entities.Car Car { get; set; }
        public List<PictureBox> Images { get; set; }

        public Create()
        {
            InitializeComponent();
            _appCar = new DBCar();
            _appImage = new DBImage();
            Images = new List<PictureBox>();
            Car = new Domain.Entities.Car();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel3.Controls.Clear();

            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Multiselect = true;
            OpenFd.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dr = OpenFd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string[] files = OpenFd.FileNames;
                int x = 20, y = 20, maxHeight = -1;
                foreach (string img in files)
                {
                    var pic = _appImage.GeneratePictureBox(img, x, y);
                    x += pic.Width + 23;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x > metroPanel3.ClientSize.Width - 100)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.metroPanel3.Controls.Add(pic);
                }
            }

        }

        private void verificarPreenchimento(object sender, EventArgs e)
        {
            var branch = metroComboBox1.Text;
            var model = metroTextBox1.Text;
            var year = metroComboBox2.Text;
            var color = metroTextBox2.Text;
            var board = metroTextBox3.Text;
            var doors = metroPanel1.Controls.OfType<RadioButton>().Where(x => x.Checked == true).FirstOrDefault();
            var fuel = metroPanel2.Controls.OfType<RadioButton>().Where(x => x.Checked == true).FirstOrDefault();
            var images = metroPanel3.Controls.OfType<PictureBox>().ToList();

            if (branch != "" && model != "" && year != "" && color != "" && doors != null && fuel != null && images.Any())
            {
                metroLinkSalvar.Enabled = true;
                Car.Board = board;
                Car.Branch = branch;
                Car.Doors = int.Parse(doors.Text);
                Car.Color = color;
                Car.Fuel = fuel.Text;
                Car.Model = model;
                Car.Year = int.Parse(year);
                Images = images;
            }
            else
            {
                metroLinkSalvar.Enabled = false;
            }
        }

        private void verficarPreencimento(object sender, ControlEventArgs e)
        {
            verificarPreenchimento(this, new EventArgs());
        }

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = _appCar.Insert(Car);
                Domain.Entities.Image img = new Domain.Entities.Image();
                foreach (var item in Images)
                {
                    _appImage.SetImage(id, item);
                }
                MetroMessageBox.Show(this, "Carro cadastro com sucess", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
                metroLinkSalvar.Enabled = false;
            }
            catch(Exception excep)
            {
                _appCar.Delete(id);
                MetroMessageBox.Show(this, "Ocorreu um erro ao salvar. Entre em contato com o administrador", "Erro" ,MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }
    }
}
