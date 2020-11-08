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
        public int CNH { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int User_Id { get; set; }
        public int CPF { get; set; }
        public string Genero { get; set; }
    }
}
