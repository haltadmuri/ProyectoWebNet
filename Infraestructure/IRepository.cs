using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public interface IRepository : IUnitOfWork
    {
        IDbSet<Customer> Customers { get; set; }

    }
}
