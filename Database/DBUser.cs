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
    public class DBUser
    {
        Connection _context = new Connection();
        private string query;

        public int Insert(User user)
        {
            int bit = user.isAdmin == true ? 1 : 0;
            query = $"Insert into Users (userName, password, isAdmin) output inserted.idUser values ('{user.Name}' , '{user.Password}' , {bit})";
            return _context.CommandWithReturnId(query);
        }

        public void Update(User user)
        {
            query = $@"Update Users 
                    set userName = '{user.Name}', password = '{user.Password}', isAdmin = {user.isAdmin} 
                    WHERE idUser = {user.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string userName)
        {
            query = $"Delete from [Users] WHERE userName = '{userName}'";
            _context.CommandWithoutReturn(query);
        }

        public User GetUser(string userName = "", string password = "", int id = 0)
        {
            if(id == 0)
                query = $@"select * from Users where username like '%{userName}%' and password like '%{password}%'";
            else
                query = $@"select * from Users where idUser = {id}";
            return _context.GetUser(query);
        }

    }
}
