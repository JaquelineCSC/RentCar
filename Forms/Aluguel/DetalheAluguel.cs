using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Aluguel
{
    public partial class DetalheAluguel : MetroFramework.Forms.MetroForm
    {
        public Domain.Entities.Rent Rent { get; set; }

        public DetalheAluguel()
        {
            InitializeComponent();
            Rent = new Domain.Entities.Rent();
        }

        private void DetalheAluguel_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }
    }
}
