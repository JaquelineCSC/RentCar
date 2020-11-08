using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
    }
}
