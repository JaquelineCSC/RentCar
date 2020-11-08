using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class Payment : Base
    {
        public int idRent { get; set; }
        public int idCard { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime paymentDate { get; set; }
        public string status { get; set; }
        public double value { get; set; }
        public string description { get; set; }
    }
}
