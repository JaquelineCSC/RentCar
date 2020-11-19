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
                    set CNHname = '{cnh.Name}', CNHnumber = {cnh.Number}, validateDate = '{cnh.ValidateDate} '
                    WHERE idCNH = {cnh.Id}";
            _context.CommandWithoutReturn(query);
        }
    }
}
