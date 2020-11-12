using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class CNH : Base
    {
        public string Name { get; set; }
        public long Number { get; set; }
        public DateTime ValidateDate { get; set; }
    }
}
