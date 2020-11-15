using CarLand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CarLand.Database
{
    public class DBCard
    {
        Connection _context = new Connection();
        public string query;


        public void Insert(Card card)
        {
            query = $"Insert into [Card] (idClient,Cardname,Cardnumber,CVC,validateDate) values ({card.idClient} , '{card.Name}', {card.Number}, {card.CVC}, '{card.ValidateDate}')";
            _context.CommandWithoutReturn(query);
        }

        public void Update(Card card)
        {
            query = $@"Update [Card] 
                    set idClient = {card.idClient}, Cardname = '{card.Name}', Cardnumber = {card.Number}, CVC = {card.CVC}, validateDate = '{card.ValidateDate}'
                    WHERE idCard = {card.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string cardname)
        {
            query = $"Delete from [Card] WHERE Cardname = '{cardname}'";
            _context.CommandWithoutReturn(query);
        }

        public List<Card> GetCard(int idClient)
        {
            query = $"Select * from [Card] where idClient = {idClient}";
            return _context.GetCard(query);
        }
    }
}
