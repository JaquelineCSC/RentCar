using CarLand.Domain.Entities;

namespace CarLand.Database
{
    public class DBAmount
    {
        Connection _context = new Connection();
        private string query;

        public void Insert(Domain.Entities.AmountCar amount)
        {
            query = $"insert into AmountsCar(idCar, Amount) values ({amount.idCar}, {(float)amount.Amount})";
            _context.CommandWithoutReturn(query);
        }
        public void Update(Domain.Entities.AmountCar amount)
        {
            query = $@"update AmountsCar set Amount = {(float)amount.Amount} where idCar = {amount.idCar}";
            _context.CommandWithoutReturn(query);
        }
        public Domain.Entities.AmountCar GetAmount(int idCar)
        {
            query = $"select * from AmountsCar where idCar = {idCar}";
            return _context.GetAmount(query);
        }

    }
}
