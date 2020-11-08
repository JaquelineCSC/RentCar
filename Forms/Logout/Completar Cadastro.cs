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
    public partial class Completar_Cadastro : MetroForm
    {
        public string UserName { get; set; }
        public int Password  { get; set; }

        public Completar_Cadastro(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Theme(manager.Theme);
            Load_Style(manager.Style);
        }

        private void Completar_Cadastro_Load(object sender, EventArgs e)
        {
        }

        public void Load_Style(MetroColorStyle style)
        {
            mdtDataNascimento.Style= style;
            mtxtNomeClientes.Style = style;
            metroLabel1.Style = style;
            metroLabel2.Style = style;
            metroLabel7.Style = style;
            metroLabel15.Style = style;
            mtxtEmail.Style = style;
            metroLabel5.Style = style;
            metroLabel14.Style = style;
            metroLabel11.Style = style;
            metroLabel3.Style = style;
            mtxtCPF.Style = style;
            metroLabel12.Style = style;
            metroLabel6.Style = style;
            mtxtTelefone.Style = style;
            metroLabel13.Style = style;
            metroLabel8.Style = style;
            mcmbGenero.Style = style;
            metroLabel10.Style = style;
            metroLabel4.Style = style;
            mtxtCNH.Style = style;
            metroLabel16.Style = style;
            metroLabel9.Style = style;
            mdtValidadeCNH.Style = style;
            metroCheckBox1.Style = style;
        }

        private void Load_Theme(MetroThemeStyle style)
        {
            mdtDataNascimento.Theme = style;
            mtxtNomeClientes.Theme = style;
            metroLabel1.Theme = style;
            metroLabel2.Theme = style;
            metroLabel7.Theme = style;
            metroLabel15.Theme = style;
            mtxtEmail.Theme = style;
            metroLabel5.Theme = style;
            metroLabel14.Theme = style;
            metroLabel11.Theme = style;
            metroLabel3.Theme = style;
            mtxtCPF.Theme = style;
            metroLabel12.Theme = style;
            metroLabel6.Theme = style;
            mtxtTelefone.Theme = style;
            metroLabel13.Theme = style;
            metroLabel8.Theme = style;
            mcmbGenero.Theme = style;
            metroLabel10.Theme = style;
            metroLabel4.Theme = style;
            mtxtCNH.Theme = style;
            metroLabel16.Theme = style;
            metroLabel9.Theme = style;
            mdtValidadeCNH.Theme = style;
            metroCheckBox1.Theme = style;
        }
    }
}
