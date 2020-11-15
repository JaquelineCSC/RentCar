using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Entities
{
    public class ClientCardCNH
    {
        public Client Client { get; set; }
        public List<Card> Card { get; set; }
        public CNH CNH { get; set; }

        public ClientCardCNH()
        {
            Client = new Client();
            CNH = new CNH();
            Card = new List<Card>();
        }
    }
}
