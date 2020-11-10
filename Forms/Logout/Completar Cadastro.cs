using CarLand.Domain.Entities;
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
        public User User { get; set; }

        public Completar_Cadastro(MetroStyleManager manager)
        {
            InitializeComponent();
            User = new User();
            this.StyleManager = manager;
        }

        private void verificarPreenchimento(object sender, EventArgs e)
        {
        }
    }
}
