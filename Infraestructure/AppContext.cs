using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class AppContext : DbContext, IUnitOfWork, IRepository
    {
       public IDbSet<Customer> Customers { get; set; }
        public AppContext():base ("DefaultConnection")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configuracion.CustomerConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
