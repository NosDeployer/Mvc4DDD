using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.Data.EntityConfig;

/*
 * Update-Database -Verbose -Force
 */

namespace Mvc4DDD.Data.Context
{
    public class Mvc4DDDContext : DbContext
    {
        public Mvc4DDDContext()
            : base("Mvc4DDD")
        {

        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<String>()
                .Configure(p => p.HasMaxLength(1024));

            modelBuilder.Configurations.Add(new CompanyConfiguration());

            /*************/

           /* modelBuilder.ComplexType<AdditionalPhonesList>()
                .Property(p => p.Serialized)
                .HasColumnName("AdditionalPhones");*/

            
        }

    }
}
