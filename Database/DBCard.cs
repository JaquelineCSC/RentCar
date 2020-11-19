using CarLand.Domain.Entities;
using System.Collections.Generic;

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
        public void Delete(long cardNumber)
        {
            query = $"Update Card set Status = 0 WHERE Cardnumber = {cardNumber}";
            _context.CommandWithoutReturn(query);
        }
        public List<Card> GetCard(int idClient)
        {
            query = $"Select * from [Card] where idClient = {idClient} and Status = 1";
            return _context.GetCard(query);
        }
    }
}
