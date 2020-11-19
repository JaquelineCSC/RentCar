using System;
using System.Collections.Generic;
using System.Data;
using CarLand.Domain.Entities;

namespace CarLand.Database
{
    public class DBCar
    {
        Connection _context = new Connection();
        public string query;

        public int Insert(Domain.Entities.Car car)
        {
            query = $@"INSERT INTO 
                        Car
                        (Color,Board,Model,Fuel,Doors,Year,Branch,Available)
                        output inserted.idCar
                    VALUES ('{car.Color}', '{car.Board}' , '{car.Model}', '{car.Fuel}', {car.Doors}, {car.Year}, '{car.Branch}', 0 )";
            return _context.CommandWithReturnId(query);
        }
        public void Update(Domain.Entities.Car car)
        {
            query = $@"Update Car 
                    set Color = '{car.Color}', Board = '{car.Board}', Model = '{car.Model}', Fuel = '{car.Fuel}', Doors = {car.Doors}, Year = {car.Year}, Branch = '{car.Branch}'  
                    WHERE idCar = {car.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(int id)
        {
            query = $"update Car set Status = 0 where idCar = {id}";
            _context.CommandWithoutReturn(query);
        }
        public void Provide(int id)
        {
            query = $"update Car set Available = 1 where idCar = {id}";
            _context.CommandWithoutReturn(query);
        }
        public Car GetCar(int id = 0, string branch = null, string model = null, string year = null, string color = null)
        {
            if (id == 0)
                query = $"select * from Car where branch = '{branch}' and model = '{model}' and year = {year} and color = '{color}'";
            else
                query = $"select * from Car where idCar = '{id}'";

            return _context.GetCar(query);
        }
        public DataSet Report()
        {
            query = "Select * from Car where Status = 1";
            return _context.ReportCars(query);
        }
        public List<Car> List(string name = "", string date = null)
        {
            DateTime datetime = DateTime.Parse(date);
            query = $@"select * from Car where Model like '%{name}%' and Available = 1 and Status = 1";
            return _context.ListCars(query);
        }
    }
}
