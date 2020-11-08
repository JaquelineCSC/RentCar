using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
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
    public partial class Esqueceu : MetroForm
    {
        private readonly DBUser _appUser = new DBUser();

        public Esqueceu(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Style(this.StyleManager.Style);
            Load_Theme(this.StyleManager.Theme);
        }
        private void Esqueceu_Load(object sender, EventArgs e)
        {
        }

        public void Load_Style(MetroColorStyle color)
        {  
            metroButton1.BackColor = GetColor(color);
            metroTextBox1.Style = color;
        }

        public void Load_Theme(MetroThemeStyle style)
        {
            metroTextBox1.Theme = style;
        }

        public Color GetColor(MetroColorStyle color)
        {
            Color retorno = new Color();
            switch (color)
            {
                case MetroColorStyle.Orange:
                    retorno = Color.DarkOrange;
                    break;
                case MetroColorStyle.Green:
                    retorno = Color.Green;
                    break;
                case MetroColorStyle.Pink:
                    retorno = Color.Pink;
                    break;
                case MetroColorStyle.Purple:
                    retorno = Color.Purple;
                    break;
                case MetroColorStyle.Red:
                    retorno = Color.Red;
                    break;
                case MetroColorStyle.Silver:
                    retorno = Color.Silver;
                    break;
                case MetroColorStyle.Yellow:
                    retorno = Color.Yellow;
                    break;
                case MetroColorStyle.Brown:
                    retorno = Color.SaddleBrown;
                    break;
                case MetroColorStyle.Magenta:
                    retorno = Color.Magenta;
                    break;
                case MetroColorStyle.Blue:
                    retorno = Color.DeepSkyBlue;
                    break;
                case MetroColorStyle.Lime:
                    retorno = Color.Lime;
                    break;
                case MetroColorStyle.Teal:
                    retorno = Color.Teal;
                    break;
            }
            return retorno;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var usuario = metroTextBox1.Text;
            if(usuario == "")
            {
                error.SetError(metroTextBox1, "Insira o usuário");
            }
            else
            {
                var user = _appUser.GetUser(usuario, 0);
                if(user.Id == 0)
                    MetroMessageBox.Show(this, "Usuário não Encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100);
                else
                    MetroMessageBox.Show(this, user.Password, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);

            }
        }
    }
}
