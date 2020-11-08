using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class Card : Base
    {
        public int idClient { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int CVC { get; set; }
        public DateTime ValidateDate { get; set; }
    }
}
