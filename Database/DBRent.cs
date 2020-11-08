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
            query = $"Insert into Rent (idCar,idEmployee,idClient,PickUpTime,DropOfTime,Amount) values ({rent.idCar} , {rent.idEmployee} , {rent.idClient} , {rent.PickTime} , {rent.DropTime} , {rent.Value} )";
            _context.CommandWithoutReturn(query);
        }

        public void Update(Rent rent)
        {
            query = $@"Update Rent 
                    set idCar = {rent.idCar}, idEmployee = {rent.idEmployee}, idClient = {rent.idClient}, PickUpTime = {rent.PickTime}, DropOfTime = {rent.DropTime}, Amount = {rent.Value}   
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
                PickTime = reader.GetInt32(5),
                DropTime = reader.GetInt32(6),
                Value = reader.GetDouble(7)
            };
        }
    }
}
