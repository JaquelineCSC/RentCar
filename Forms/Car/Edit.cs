using CarLand.Database;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Car
{
    public partial class EditCar : MetroForm
    {
        public Domain.Entities.Car Car { get; set; }
        public DBCar _appCar { get; set; }
        public DBImage _appImage { get; set; }
        public List<PictureBox> Images { get; set; }


        public EditCar()
        {
            InitializeComponent();
            _appCar = new DBCar();
            _appImage = new DBImage();
            Car = new Domain.Entities.Car();
        }

        private void EditCar_Load(object sender, EventArgs e)
        {
            if (Car != null)
            {
                metroComboBox1.SelectedItem = Car.Branch;
                metroTextBox1.Text = Car.Model;
                var door = metroPanel1.Controls.OfType<RadioButton>().Where(x => x.Text == Car.Doors.ToString()).FirstOrDefault();
                var fuel = metroPanel2.Controls.OfType<RadioButton>().Where(x => x.Text == Car.Fuel).FirstOrDefault();
                door.Checked = true;
                fuel.Checked = true;
                metroTextBox3.Text = Car.Board;
                metroComboBox2.SelectedItem = Car.Year.ToString();
                metroTextBox2.Text = Car.Color;
                var images = _appImage.GetImages(Car.Id);
                if (images.Count > 0)
                {
                    int x = 20, y = 20, maxHeight = -1;
                    foreach (var item in images)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = (Bitmap)Image.FromFile(Servers.path + item.Path + item.Name);
                        pic.Name = item.Name;
                        pic.Location = new Point(x, y);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Multiselect = true;
            OpenFd.Filter = "Images only. |*.jpg; *.jpeg; *.png;";

            DialogResult dr = OpenFd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                metroPanel3.Controls.Clear();
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

        private void metroLinkSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _appCar.Update(Car);
                _appImage.Delete(Car.Id);
                Domain.Entities.Image img = new Domain.Entities.Image();
                foreach (var item in Images)
                {
                    _appImage.SetImage(Car.Id, item);
                }
                MetroMessageBox.Show(this, "Carro cadastro com sucess", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
            }
            catch
            {
                MetroMessageBox.Show(this, "Ocorreu um erro ao salvar. Entre em contato com o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
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

        private void verificarPreenchimento(object sender, ControlEventArgs e)
        {
            verificarPreenchimento(this, new EventArgs());
        }
    }
}
