using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class Image : Base
    {
        public int idCar { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public bool Main { get; set; }
    }
}
