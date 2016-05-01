using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configuracion
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            this.Property(x => x.Id).IsRequired();
            this.Property(x => x.Name).HasMaxLength(50).IsRequired();
            this.Property(x => x.Telephone).IsRequired();
            this.Property(x => x.Mail).HasMaxLength(50).IsRequired();
            this.Property(x => x.UserName).HasMaxLength(50).IsRequired();
        }
    }
}
