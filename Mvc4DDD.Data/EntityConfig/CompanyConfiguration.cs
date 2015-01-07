using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Mvc4DDD.Domain.Entities;

namespace Mvc4DDD.Data.EntityConfig
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            HasKey(c => c.CompanyId);

            Property(c => c.Name)
                .IsRequired();

           /* Property(c => c.MainPhone)
                .IsRequired();

            Property(c => c.EmailAddress)
                .IsRequired();

            Property(c => c.WWW)
                .IsRequired();

            Property(c => c.City)
                .IsRequired();

            Property(c => c.Country)
                .IsRequired();

             Property(c => c.XCoord)
                .IsRequired();

             Property(c => c.YCoord)
                .IsRequired();
            */
             
        }
    }
}
