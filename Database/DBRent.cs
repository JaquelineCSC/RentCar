using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
                case PaymentTypeEnum.Card:
                    payment = 2;
                    idCard = ", idCard";
                    idCardVlaue = $",{rent.idCard}";
                    break;
                case PaymentTypeEnum.Money:
                    payment = 3;
                    break;
            }
            if (rent.idEmployee == 0)
                query = $"Insert into Rent (idCar,idEmployee,idClient,PickUpTime,DropOfTime,Amount,PaymentType{idCard}) values ({rent.idCar} , null , {rent.idClient} , '{rent.PickUpDate}' , '{rent.DropOffDate}' , {rent.Value}, {payment}{idCardVlaue} )";
            else
                query = $"Insert into Rent (idCar,idEmployee,idClient,PickUpTime,DropOfTime,Amount,PaymentType{idCard}) values ({rent.idCar} , {rent.idEmployee} , {rent.idClient} , '{rent.PickUpDate}' , '{rent.DropOffDate}' , {rent.Value}, {payment}{idCardVlaue} )";

            _context.CommandWithoutReturn(query);
        }

        public void Update(Rent rent)
        {
            query = $@"Update Rent 
                    set idCar = {rent.idCar}, idEmployee = {rent.idEmployee}, idClient = {rent.idClient}, PickUpTime = {rent.PickUpDate}, DropOfTime = {rent.DropOffDate}, Amount = {rent.Value}   
                    WHERE idRent = {rent.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(int idrent)
        {
            query = $"Delete from Rent WHERE idRent = {idrent}";
            _context.CommandWithoutReturn(query);
        }

        public Rent GetRent(int idrent)
        {
            query = $"Select idRent from Rent where idRent =  {idrent}";
            var reader = _context.Consult(query);
            return ConstructorRent(reader);
        }

        public Rent ConstructorRent(SqlDataReader reader)
        {
            return new Rent()
            {
                Id = reader.GetInt32(1),
                idCar = reader.GetInt32(2),
                idEmployee = reader.GetInt32(3),
                idClient = reader.GetInt32(4),
                PickUpDate = reader.GetDateTime(5),
                DropOffDate = reader.GetDateTime(6),
                Value = reader.GetDouble(7)
            };
        }
    }
}
