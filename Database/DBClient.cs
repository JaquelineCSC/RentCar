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
                    set Clientname = '{client.Name}', Birth = '{client.DateOfBirth}', Email = '{client.Email}', Phone = {client.Phone}, Gener = '{client.Genero}', CPF = {client.CPF} 
                    WHERE idClient = {client.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string clientName)
        {
            query = $"Delete from Client WHERE Clientename = '{clientName}'";
            _context.CommandWithoutReturn(query);
        }

        public Client GetClientByUser(int idUser)
        {
            query = $"Select * from Client where idUser = {idUser}";
            return _context.GetClient(query);
        }

        public Client GetClientById(int idClient)
        {
            query = $"Select * from Client where idClient = {idClient}";
            return _context.GetClient(query);
        }

        public ClientCardCNH GetClientCardCNHByUser(int idUser)
        {
            query = $"select c.*, cd.*, cn.* from Client c inner join Card cd on cd.idClient = c.idClient inner join CNH cn on cn.idCNH = c.idCNH where c.idUser = {idUser}";
            return _context.GetClientCardCNHByUserId(query);
        }

        public ClientCardCNH GetClientCNHByUser(int idUser)
        {
            query = $"select c.*, cn.* from Client c inner join CNH cn on cn.idCNH = c.idCNH where c.idUser = {idUser}";
            return _context.GetClientCNHByUserId(query);
        }

        public Client GetClientByEmail(string email)
        {
            query = $"select * from Client where Email = '{email}'";
            return _context.GetClient(query);
        }

    }
}
