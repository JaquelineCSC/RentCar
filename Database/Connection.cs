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
    class Connection
    {

        private SqlConnection cn = new SqlConnection();
        private SqlCommand cd = new SqlCommand();

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
            catch (Exception e)
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

        public Domain.Entities.Car ConstructorCar(SqlDataReader reader)
        {
            return new Domain.Entities.Car()
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

        public Domain.Entities.Car GetCar(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            Car car = new Car();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                car = ConstructorCar(reader);
            }
            cn.Close();
            return car;
        }

        #endregion

        #region User

        public User GetUser(string sql)
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
                isAdmin = reader.GetBoolean(3),
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

        #region Card

        public Card ConstructorCard(SqlDataReader reader, int i)
        {
            return new Card()
            {
                Id = reader.GetInt32(i),
                idClient = reader.GetInt32(i + 1),
                Name = reader.GetString(i + 2),
                Number = long.Parse(reader.GetSqlInt64(i + 3).ToString()),
                CVC = reader.GetInt32(i + 4),
                ValidateDate = reader.GetDateTime(i + 5),
            };
        }

        #endregion

        #region Client

        public Client GetClientByUserId(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            Client client = new Client();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                client = ConstructorClient(reader);
            }
            cn.Close();
            return client;
        }

        public Client GetClientByEmail(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            Client client = new Client();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                client = ConstructorClient(reader);
            }
            cn.Close();
            return client;
        }

        public Client ConstructorClient(SqlDataReader reader)
        {
            return new Client()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                User_Id = reader.GetInt32(2),
                CPF = reader.GetInt64(3),
                CNH_Id = reader.GetInt32(4),
                DateOfBirth = reader.GetDateTime(5),
                Phone = reader.GetInt64(6),
                Email = reader.GetString(7),
                Genero = reader.GetString(8)
            };
        }
        #endregion

        #region CNH

        public CNH ConstructorCNH(SqlDataReader reader, int i)
        {
            return new CNH()
            {
                Id = reader.GetInt32(i),
                Name = reader.GetString(i + 1),
                Number = long.Parse(reader.GetInt64(i + 2).ToString()),
                ValidateDate = reader.GetDateTime(i + 3),
            };
        }

        #endregion

        #region InnerJoins

        public ClientCardCNH GetClientCardCNHByUserId(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            ClientCardCNH clientCardCNH = new ClientCardCNH();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                clientCardCNH.Client = ConstructorClient(reader);
                clientCardCNH.CNH = ConstructorCNH(reader, 15);
                while (reader.Read())
                {
                    clientCardCNH.Card.Add(ConstructorCard(reader, 9));
                }
            }
            cn.Close();
            return clientCardCNH;
        }

        public ClientCardCNH GetClientCNHByUserId(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            ClientCardCNH clientCNH = new ClientCardCNH();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                clientCNH.Client = ConstructorClient(reader);
                clientCNH.CNH = ConstructorCNH(reader, 9);
            }
            cn.Close();
            return clientCNH;
        }

        #endregion

        #region Employee

        public Employee GetEmployeeByUserId(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            Employee employee = new Employee();
            SqlDataReader reader = cd.ExecuteReader();
            if (reader.Read())
            {
                employee = ConstructorEmployee(reader);
            }
            cn.Close();
            return employee;
        }

        public Employee ConstructorEmployee(SqlDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                idUser = reader.GetInt32(2),
            };
        }

        #endregion

        #region Card

        public List<Card> GetCard(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            List<Card> cards = new List<Card>();
            SqlDataReader reader = cd.ExecuteReader();
            while (reader.Read())
            {
                cards.Add(ConstructorCard(reader));
            }
            cn.Close();
            return cards;
        }

        public Card ConstructorCard(SqlDataReader reader)
        {
            return new Card()
            {
                Id = reader.GetInt32(0),
                idClient = reader.GetInt32(1),
                Name = reader.GetString(2),
                Number = reader.GetInt64(3),
                CVC = reader.GetInt32(4),
                ValidateDate = reader.GetDateTime(5)
            };
        }

        #endregion
    }
}
