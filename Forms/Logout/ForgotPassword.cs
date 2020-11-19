using CarLand.Database;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class ForgotPassword : MetroForm
    {
        private readonly DBUser _appUser = new DBUser();

        public ForgotPassword(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
        }

        private void Load_Page()
        {
            metroButton1.BackColor = GetColor(this.StyleManager.Style);
            metroTextBox1.Style = this.StyleManager.Style;

            metroTextBox1.Theme = this.StyleManager.Theme;
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
                var user = _appUser.GetUser(userName: usuario);
                if(user.Id == 0)
                    MetroMessageBox.Show(this, "Usuário não Encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100);
                else
                    MetroMessageBox.Show(this, user.Password, "Sua senha é", MessageBoxButtons.OK, MessageBoxIcon.Question, 100);

            }
        }
    }
}
