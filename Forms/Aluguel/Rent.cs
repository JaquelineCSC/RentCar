using CarLand.Domain.Entities;
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

namespace CarLand.Forms.Aluguel
{
    public partial class Rent : MetroForm
    {
        public User User { get; set; }

        public Rent()
        {
            InitializeComponent();
            User = new User();
        }
    }
}
