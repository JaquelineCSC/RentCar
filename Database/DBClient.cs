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
    public class DBClient
    {
        Connection _context = new Connection();
        private string query;

        public void Insert(Client client)
        {
            query = $"Insert into Client (Clientname, idCNH, Birth, Email, Phone, idUser, Gener, CPF) values ('{client.Name}' , {client.CNH_Id} , '{client.DateOfBirth}' , '{client.Email}' , {client.Phone} , {client.User_Id} , '{client.Genero}' , {client.CPF})";
            _context.CommandWithoutReturn(query);
        }
        public void Update(Client client)
        {
            query = $@"Update Client 
                    set Clientname = '{client.Name}', idCNH = {client.CNH_Id}, Birth = {client.DateOfBirth}, Email = '{client.Email}', Phone = {client.Phone}, idUser = {client.User_Id}, Gener = '{client.Genero}', CPF = {client.CPF} 
                    WHERE idClient = {client.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string clientName)
        {
            query = $"Delete from Client WHERE Clientename = '{clientName}'";
            _context.CommandWithoutReturn(query);
        }

        public Client GetClient(string clientName)
        {
            query = $"Select idClient from Client where Clientename LIKE '" + clientName + "%'";
            var reader = _context.Consult(query);
            return ConstructorClient(reader);
        }

        public Client GetClientByUser(int idUser)
        {
            query = $"Select * from Client where idUser = {idUser}";
            return _context.GetClientByUserId(query);
        }

        public ClientCardCNH GetClientCardCNHByUser(int idUser)
        {
            query = $"select c.*, cd.*, cn.* from Client c inner join Card cd on cd.idClient = c.idClient inner join CNH cn on cn.idCNH = c.idCNH where c.idUser = {idUser}";
            return _context.GetClientCardCNHByUserId(query);
        }

        public Client ConstructorClient(SqlDataReader reader)
        {
            return new Client()
            {
                Id = reader.GetInt32(1),
                Name = reader.GetString(2),
                Email = reader.GetString(3),
                Phone = reader.GetInt32(4),
                CNH_Id = reader.GetInt32(5),
                DateOfBirth = reader.GetDateTime(6),
                User_Id = reader.GetInt32(7),
                Genero = reader.GetString(8),
                CPF = reader.GetInt32(9),
            };
        }
    }
}
