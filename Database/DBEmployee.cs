using CarLand.Domain.Entities;

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
                    set EmployeeName = '{employee.Name}'
                    WHERE idEmployee = {employee.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(string employname)
        {
            query = $"Delete from Employee WHERE EmployeeName = '{employname}'";
            _context.CommandWithoutReturn(query);
        }
        public Employee GetEmployee(int idEmployee = 0, int idUser = 0, string employeeName = null)
        {
            if (idEmployee != 0)
            {
                query = $"Select * from Employee where idEmployee = {idEmployee}";
            }
            else
            {
                if (employeeName != null)
                    query = $"Select * from Employee where EmployeeName = '{employeeName}'";
                else
                    query = $"Select * from Employee where idUser = {idUser}";
            }

            return _context.GetEmployeeByUserId(query);
        }
    }
}
