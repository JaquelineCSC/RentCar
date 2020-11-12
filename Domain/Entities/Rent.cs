using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class Rent : Base
    {
        public int idCar { get; set; }
        public int idEmployee { get; set; }
        public int idClient { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public double Value { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public int idCard { get; set; }
    }
}
