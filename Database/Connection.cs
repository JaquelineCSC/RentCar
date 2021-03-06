﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CarLand.Domain.Entities;

namespace CarLand.Database
{
    class Connection
    {

        private SqlConnection cn = new SqlConnection();
        private SqlCommand cd = new SqlCommand();

        public int Campo { get; set; }

        private void Connect()
        {
            cn.ConnectionString = Servers.Paulo;
            cn.Open();
        }
        public void CommandWithoutReturn(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public int CommandWithReturnId(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            int id = Convert.ToInt32(cd.ExecuteScalar());
            cn.Close();
            return id;
        }

        public SqlDataReader Consult(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            try
            {
                var dr = cd.ExecuteReader();
                cn.Close();
                return dr;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #region Cars
        public List<Car> ListCars(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            List<Car> carros = new List<Car>();
            SqlDataReader reader = cd.ExecuteReader();
            while (reader.Read())
            {
                carros.Add(ConstructorCar(reader));
            }
            cn.Close();
            return carros;
        }

        public Car ConstructorCar(SqlDataReader reader)
        {
            return new Car()
            {
                Id = reader.GetInt32(0),
                Color = reader.GetString(1),
                Board = reader.GetString(2),
                Model = reader.GetString(3),
                Fuel = reader.GetString(4),
                Doors = reader.GetInt32(5),
                Branch = reader.GetString(6),
                Year = reader.GetInt32(7),
            };
        }

        public Car GetCar(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            Car car = new Car();
            SqlDataReader reader = cd.ExecuteReader();
            if(reader.Read())
            {
                car = ConstructorCar(reader);
            }
            cn.Close();
            return car;
        }

        #endregion

        #region User

        public User GetUserByName(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            User user = new User();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                user = ConstructorUser(reader);
            }
            cn.Close();
            return user;
        }

        public User ConstructorUser(SqlDataReader reader)
        {
            return new User()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Password = reader.GetString(2),
                Admin = reader.GetBoolean(3),
            };
        }

        #endregion

        #region Image

        public List<Image> GetImages(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            List<Image> images = new List<Image>();
            SqlDataReader reader = cd.ExecuteReader();
            while (reader.Read())
            {
                images.Add(ConstructorImage(reader));
            }
            cn.Close();
            return images;
        }

        public Image ConstructorImage(SqlDataReader reader)
        {
            return new Image()
            {
                Id = reader.GetInt32(0),
                idCar = reader.GetInt32(1),
                Path = reader.GetString(2),
                Name = reader.GetString(3),
            };
        }

        #endregion

    }
}
