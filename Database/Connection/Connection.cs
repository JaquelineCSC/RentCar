using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Database.Connection
{
    public class Connection
    {
        private SqlConnection _context = new SqlConnection();
        private SqlCommand Command = new SqlCommand();

        public void Open()
        {
            _context.ConnectionString = Server.Samuel;
            _context.Open();
        }
        public void CommandWithoutReturn(string sql)
        {
            Open();
            Command.Connection = _context;
            Command.CommandText = sql;
            Command.ExecuteNonQuery();
            _context.Close();
        }

        public SqlDataReader GetById(string sql)
        {
            Open();
            Command.Connection = _context;
            Command.CommandText = sql;
            SqlDataReader reader = Command.ExecuteReader();
            _context.Close();
            return reader;
        }

        public SqlDataReader List(string sql)
        {
            Open();
            Command.Connection = _context;
            Command.CommandText = sql;
            SqlDataReader reader = Command.ExecuteReader();
            _context.Close();
            return reader;
        }
    }
}
