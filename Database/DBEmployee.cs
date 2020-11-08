using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CarLand.Domain.Entities;
using System.Data;

namespace CarLand.Database
{
    public class DBEmployee
    {
        Connection _context = new Connection();
        private string query;

        public void Insert(Employee employee)
        {
            query = $"Insert into Employee (EmployeeName, idUser) values ('{employee.Name}' , {employee.idUser})";
            _context.CommandWithoutReturn(query);
        }

        public void Update(Employee employee)
        {
            query = $@"Update Employee 
                    set EmployeeName = '{employee.Name}', idUser = {employee.idUser}
                    WHERE idEmployee = {employee.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string employname)
        {
            query = $"Delete from Employee WHERE EmployeeName = '{employname}'";
            _context.CommandWithoutReturn(query);
        }

        public Employee GetWorker(string employname)
        {
            query = $"Select idEmployee from Employee where EmployeeName LIKE '" + employname + "%'";
            var reader = _context.Consult(query);
            return ConstructorEmployee(reader);
        }

        public Employee ConstructorEmployee(SqlDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt32(1),
                Name = reader.GetString(2),
                idUser = reader.GetInt32(3),
            };
        }
    }
}
