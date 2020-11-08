using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CarLand.Domain.Entities;

namespace CarLand.Database
{
    public class DBPayment
    {
        Connection _context = new Connection();
        private string query;

        public void Insert(Payment payment)
        {
            query = $"Insert into Payment (idRent,idCard,DueDate,PaymentDate,Status,Amount,Description) values ({payment.idRent} , {payment.idCard} , '{payment.dueDate}' , '{payment.paymentDate}' , '{payment.status}' , {payment.value} , '{payment.description}')";
            _context.CommandWithoutReturn(query);
        }

        public void Update(Payment payment)
        {
            query = $@"Update Payment 
                    set idRent = {payment.idRent}, idCard = {payment.idCard}, DueDate = '{payment.dueDate}', PaymentDate = '{payment.paymentDate}', Status = '{payment.status}', Amount = {payment.value} , Description = '{payment.description}'                        
                    WHERE idPayment = {payment.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(int idpayment)
        {
            query = $"Delete from Payment WHERE idPayment = {idpayment}";
            _context.CommandWithoutReturn(query);
        }

        public Payment GetPayment(int id)
        {
            query = $"Select idPayment from Payment where idPayment = {id}";
            var reader = _context.Consult(query);
            return ConstructorPayment(reader);
        }

        public Payment ConstructorPayment(SqlDataReader reader)
        {
            return new Payment()
            {
                Id = reader.GetInt32(1),
                idRent = reader.GetInt32(2),
                idCard = reader.GetInt32(3),
                dueDate = reader.GetDateTime(4),
                paymentDate = reader.GetDateTime(5),
                status = reader.GetString(6),
                value = reader.GetDouble(7),
                description = reader.GetString(8),
            };
        }
    }
}

