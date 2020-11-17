using CarLand.Database;
using MetroFramework;
using MetroFramework.Controls;
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
using System.Text.RegularExpressions;
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
                    pic.Click += new EventHandler(AddMain); 
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

        public void AddMain(object sender, EventArgs e)
        {
            var otherImages = metroPanel3.Controls.OfType<PictureBox>().Where(x => x.BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D).ToList();
            otherImages.ForEach(x => x.BorderStyle = System.Windows.Forms.BorderStyle.None);

            PictureBox pic = (PictureBox)sender;
            pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            verificarPreenchimento(this, new EventArgs());
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

            if (branch != "" && model != "" && year != "" && color != "" && doors != null && fuel != null && images.Any() && images.Where(x=> x.BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D).Any())
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
            catch
            {
                _appCar.Delete(id);
                MetroMessageBox.Show(this, "Erro inesperado. Por favor entre em contato com seu administrador", "Erro" ,MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void VerificarPreenchimentoModelo(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == metroTextBox1.Name)
            {
                Regex rgx = new Regex("[^\\w\\.-]");
                metroTextBox1.Text = rgx.Replace(metroTextBox1.Text, "");
            }
        }

        private void VerificarPreenchimentoCor(object sender, KeyEventArgs e)
        {
                MetroTextBox x = (MetroTextBox)sender;
                if (x.Name == metroTextBox2.Name)
                {
                    Regex rgx = new Regex("[^a-zA-Z -]");
                    metroTextBox2.Text = rgx.Replace(metroTextBox2.Text, "");
                }
         
   
        }
        private void VerificarPreenchimentoPlaca(object sender, KeyEventArgs e)
        {
            MetroTextBox x = (MetroTextBox)sender;
            if (x.Name == metroTextBox3.Name)
            {
                Regex rgx = new Regex("[^A-Z0-9]");
                metroTextBox3.Text = rgx.Replace(metroTextBox3.Text, "");
            }
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}

