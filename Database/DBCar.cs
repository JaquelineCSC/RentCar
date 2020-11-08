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
    public class DBCar
    {
        Connection _context = new Connection();
        public string query;

        public int Insert(Car car)
        {
            query = $@"INSERT INTO 
                        Car
                        (Color,Board,Model,Fuel,Doors,Year,Branch)
                        output inserted.idCar
                    VALUES ('{car.Color}', '{car.Board}' , '{car.Model}', '{car.Fuel}', {car.Doors}, {car.Year}, '{car.Branch}' )";
            return _context.CommandWithReturnId(query);
        }

        public void Update(Car car)
        {
            query = $@"Update Car 
                    set Color = '{car.Color}', Board = '{car.Board}', Model = '{car.Model}', Fuel = '{car.Fuel}', Doors = {car.Doors}, Year = {car.Year}, Branch = '{car.Branch}'  
                    WHERE idCar = {car.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string board)
        {
            query = $"Delete from Car WHERE Board = '{board}'";
            _context.CommandWithoutReturn(query);
        }

        public Car GetCar(int id)
        {
            query = $"select * from Car where idCar = '{id}'";
            return _context.GetCar(query);
        }

        public List<Car> List()
        {
            query = "SELECT * FROM Car";
            return  _context.ListCars(query);
        }

        public Car ConstructorCar(SqlDataReader reader)
        {
            return new Car()
            {
                Id = reader.GetInt32(1),
                Color = reader.GetString(2),
                Board = reader.GetString(3),
                Model = reader.GetString(4),
                Fuel = reader.GetString(5),
                Doors = reader.GetInt32(6),
                Year = reader.GetInt32(7),
                Branch = reader.GetString(8)
            };
        }
    }
}
