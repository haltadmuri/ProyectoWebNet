using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;

namespace Service
{
    public class CustomerService : ICustomerService<Customer>
    {
        readonly IRepository _context;
        public CustomerService(IRepository context)
        {
            this._context = context;
        }
        public Customer Insert(Customer instancia)
        {
            _context.Customers.Add(instancia);
            _context.SaveChanges();
            return instancia;
        }
        public int Edit(Customer instancia)
        {
            var Usuario = Get(instancia.Id);
            Usuario.Name = instancia.Name;
            Usuario.UserName = instancia.UserName;
            Usuario.Telephone = instancia.Telephone;
            Usuario.Mail = instancia.Mail;
            return _context.SaveChanges();
        }
        public int Delete(Customer instancia)
        {
            var Instancia = Get(instancia.Id);
            _context.Customers.Remove(Instancia);
            return _context.SaveChanges();
        }
        public IEnumerable<Customer> GetList(string nombre)
        {
            return _context.Customers.Where(x => x.Name == (nombre ?? x.Name)).ToList();
        }
        public Customer Get(int Identity)
        {
            return _context.Customers.Where(c => c.Id == Identity).FirstOrDefault();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}

