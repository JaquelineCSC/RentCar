using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarLand.Forms.Car
{
    public partial class Create : MetroForm
    {

        public readonly DBImage _appImage = new DBImage();
        public readonly DBCar _appCar = new DBCar();

        public Domain.Entities.Car Car = new Domain.Entities.Car();
        public List<PictureBox> Images = new List<PictureBox>();

        public Create(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
        }

        private void Load_Page()
        {
            //Theme
            metroLinkSalvar.Theme = this.StyleManager.Theme;
            metroButton1.Theme = this.StyleManager.Theme;
            metroComboBox1.Theme = this.StyleManager.Theme;
            metroComboBox2.Theme = this.StyleManager.Theme;
            metroLabel1.Theme = this.StyleManager.Theme;
            metroLabel10.Theme = this.StyleManager.Theme;
            metroLabel11.Theme = this.StyleManager.Theme;
            metroLabel12.Theme = this.StyleManager.Theme;
            metroLabel13.Theme = this.StyleManager.Theme;
            metroLabel14.Theme = this.StyleManager.Theme;
            metroLabel15.Theme = this.StyleManager.Theme;
            metroLabel2.Theme = this.StyleManager.Theme;
            metroLabel3.Theme = this.StyleManager.Theme;
            metroLabel4.Theme = this.StyleManager.Theme;
            metroLabel5.Theme = this.StyleManager.Theme;
            metroLabel6.Theme = this.StyleManager.Theme;
            metroLabel7.Theme = this.StyleManager.Theme;
            metroLabel8.Theme = this.StyleManager.Theme;
            metroLabel9.Theme = this.StyleManager.Theme;
            metroPanel1.Theme = this.StyleManager.Theme;
            metroPanel2.Theme = this.StyleManager.Theme;
            metroPanel3.Theme = this.StyleManager.Theme;
            metroRadioButton1.Theme = this.StyleManager.Theme;
            metroRadioButton2.Theme = this.StyleManager.Theme;
            metroRadioButton3.Theme = this.StyleManager.Theme;
            metroRadioButton4.Theme = this.StyleManager.Theme;
            metroRadioButton5.Theme = this.StyleManager.Theme;
            metroTextBox1.Theme = this.StyleManager.Theme;
            metroTextBox2.Theme = this.StyleManager.Theme;
            metroTextBox3.Theme = this.StyleManager.Theme;
            Modelo.Theme = this.StyleManager.Theme;

            //Style
            metroLinkSalvar.Style = this.StyleManager.Style;
            metroComboBox1.Style = this.StyleManager.Style;
            metroComboBox2.Style = this.StyleManager.Style;
            metroLabel1.Style = this.StyleManager.Style;
            metroLabel10.Style = this.StyleManager.Style;
            metroLabel11.Style = this.StyleManager.Style;
            metroLabel12.Style = this.StyleManager.Style;
            metroLabel13.Style = this.StyleManager.Style;
            metroLabel14.Style = this.StyleManager.Style;
            metroLabel15.Style = this.StyleManager.Style;
            metroLabel2.Style = this.StyleManager.Style;
            metroLabel3.Style = this.StyleManager.Style;
            metroLabel4.Style = this.StyleManager.Style;
            metroLabel5.Style = this.StyleManager.Style;
            metroLabel6.Style = this.StyleManager.Style;
            metroLabel7.Style = this.StyleManager.Style;
            metroLabel8.Style = this.StyleManager.Style;
            metroLabel9.Style = this.StyleManager.Style;
            metroPanel1.Style = this.StyleManager.Style;
            metroPanel2.Style = this.StyleManager.Style;
            metroPanel3.Style = this.StyleManager.Style;
            metroRadioButton1.Style = this.StyleManager.Style;
            metroRadioButton2.Style = this.StyleManager.Style;
            metroRadioButton3.Style = this.StyleManager.Style;
            metroRadioButton4.Style = this.StyleManager.Style;
            metroRadioButton5.Style = this.StyleManager.Style;
            metroTextBox1.Style = this.StyleManager.Style;
            metroTextBox2.Style = this.StyleManager.Style;
            metroTextBox3.Style = this.StyleManager.Style;
            Modelo.Style = this.StyleManager.Style;
            metroButton1.Style = this.StyleManager.Style;

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
                MetroMessageBox.Show(this, "Carro cadastro com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);
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
                Regex rgx = new Regex("[^\\w\\. -]");
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
    }
}

