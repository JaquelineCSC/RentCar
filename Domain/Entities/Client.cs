using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class Client : Base
    {
        public string Name { get; set; }
        public long CNH { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public int User_Id { get; set; }
        public long CPF { get; set; }
        public string Genero { get; set; }
    }
}
