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
    public class DBCNH
    {
        Connection _context = new Connection();
        private string query;

        public int Insert(CNH cnh)
        {
            query = $"Insert into CNH (CNHname, CNHnumber, validateDate) output inserted.idCNH values ('{cnh.Name}' , {cnh.Number} , '{cnh.ValidateDate}')";
            return _context.CommandWithReturnId(query);
        }

        public void Update(CNH cnh)
        {
            query = $@"Update CNH 
                    set CNHname = '{cnh.Name}', CNHnumber = {cnh.Number}, validateDate = {cnh.ValidateDate} 
                    WHERE idCNH = {cnh.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string cnhName)
        {
            query = $"Delete from CNH WHERE CNHname = '{cnhName}'";
            _context.CommandWithoutReturn(query);
        }

        public CNH GetCNH(string cnhName)
        {
            query = $"Select idCNH from CNH where CNHname LIKE '" + cnhName + "%'";
            var reader = _context.Consult(query);
            return ConstructorCNH(reader);
        }

        public CNH ConstructorCNH(SqlDataReader reader)
        {
            return new CNH()
            {
                Id = reader.GetInt32(1),
                Name = reader.GetString(2),
                Number = reader.GetInt32(3),
                ValidateDate = reader.GetDateTime(4)
            };
        }
    }
}
