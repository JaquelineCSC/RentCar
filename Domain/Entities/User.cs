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
        public bool isAdmin { get; set; }

        public void Clear()
        {
            Id = 0;
            Name = null;
            Password = null;
        }

        public User(string name, string password, bool isAdmin)
        {
            Name = name;
            Password = password;
            this.isAdmin = isAdmin;
        }

        public User()
        {

        }
    }
}
