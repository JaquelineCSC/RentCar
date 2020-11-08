using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace CarLand.Forms
{
    public partial class Registrar_se : MetroForm
    {
        public Registrar_se(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Style(this.StyleManager.Style);
            Load_Theme(this.StyleManager.Theme);
        }

        public void Load_Style(MetroColorStyle style)
        {
            mtxtUsuarioClientes.Style = style;
            mtxtSenhaClientes.Style = style;
            metroTextBox1.Style = style;
        }

        public void Load_Theme(MetroThemeStyle style)
        {
            mtxtUsuarioClientes.Theme = style;
            mtxtSenhaClientes.Theme = style;
            metroTextBox1.Theme = style;
            metroLink1.Theme = style;
        }

        private void metroLabel2_Click(object sender, System.EventArgs e)
        {

        }

        private void mtxtUsuarioClientes_Click(object sender, System.EventArgs e)
        {

        }

        private void mtxtSenhaClientes_Click(object sender, System.EventArgs e)
        {

        }

        private void verficiarPreenchimento(object sender, System.EventArgs e)
        {
            if (mtxtUsuarioClientes.Text != "" && mtxtSenhaClientes.Text != "" && metroTextBox1.Text != "")
                metroLink1.Enabled = true;
        }

        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            if (mtxtSenhaClientes.Text == "")
            {
                errors.SetError(this.mtxtSenhaClientes, "Campo Obrigatório");
            }
            if (metroTextBox1.Text == "")
            {
                errors.SetError(this.metroTextBox1, "Campo Obrigatório");
            }
            if(mtxtUsuarioClientes.Text != "")
            {
                errors.SetError(this.mtxtUsuarioClientes, "Campo Obrigatório");
            }
            if (mtxtSenhaClientes.Text != metroTextBox1.Text)
            {
                errors.SetError(this.mtxtSenhaClientes, "Os campos não conferem");
                errors.SetError(this.metroTextBox1, "Os campos não conferem");
            }
            if(mtxtUsuarioClientes.Text != "" && metroTextBox1.Text == mtxtSenhaClientes.Text)
            {
                Completar_Cadastro form = new Completar_Cadastro(this.StyleManager);
                form.ShowDialog();
            }
        }

        private void Registrar_se_Load(object sender, System.EventArgs e)
        {

        }

        private void tooltipo(object sender, System.EventArgs e)
        {
            metroLink1.Enabled = true;
            metroToolTip1.Show("Preencha os campos para prosseguir", metroLink1);
        }
    }
}
