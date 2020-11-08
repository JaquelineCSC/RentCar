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

        public void Insert(User user)
        {
            query = $"Insert into Users (userName, password, isAdmin) values ('{user.Name}' , '{user.Password}' , {user.Admin})";
            _context.CommandWithoutReturn(query);
        }

        public void Update(User user)
        {
            query = $@"Update Users 
                    set userName = '{user.Name}', password = '{user.Password}', isAdmin = {user.Admin} 
                    WHERE idUser = {user.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string userName)
        {
            query = $"Delete from [Users] WHERE userName = '{userName}'";
            _context.CommandWithoutReturn(query);
        }

        public User GetUser(string userName, int password)
        {
            if(password == 0)
                query = $@"select * from Users where userName like '{userName}'";
            else
                query = $@"select * from Users where username like '{userName}' and password = '{password}'";
            return _context.GetUserByName(query);
        }

        
    }
}
