using System.Data;
using CarLand.Domain.Entities;

namespace CarLand.Database
{
    public class DBRent
    {
        Connection _context = new Connection();
        public string query;

        public void Insert(Rent rent)
        {
            string idCard = "";
            string idCardVlaue = "";
            int payment = 3;
            switch (rent.PaymentType)
            {
                case PaymentTypeEnum.Billet:
                    payment = 1;
                    break;
                case PaymentTypeEnum.Money:
                    payment = 2;
                    break;
                case PaymentTypeEnum.Card:
                    payment = 3;
                    idCard = ", idCard";
                    idCardVlaue = $",{rent.idCard}";
                    break;
            }
            if (rent.idEmployee == 0)
                query = $"Insert into Rent (idCar,idEmployee,idClient,PickUpTime,DropOfTime,Amount,PaymentType{idCard}) values ({rent.idCar} , null , {rent.idClient} , '{rent.PickUpDate}' , '{rent.DropOffDate}' , {rent.Value}, {payment}{idCardVlaue} )";
            else
                query = $"Insert into Rent (idCar,idEmployee,idClient,PickUpTime,DropOfTime,Amount,PaymentType{idCard}) values ({rent.idCar} , {rent.idEmployee} , {rent.idClient} , '{rent.PickUpDate}' , '{rent.DropOffDate}' , {rent.Value}, {payment}{idCardVlaue} )";

            _context.CommandWithoutReturn(query);
        }
        public DataSet Report()
        {
            query = "Select * from Rent";
            return _context.ReportRent(query);
        }
    }
}
