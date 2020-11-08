using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class Car : Base
    {
        public string Color { get; set; }
        public string Board { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }
        public int Doors { get; set; }
        public int Year { get; set; }
        public string Branch { get; set; }
    }
}
