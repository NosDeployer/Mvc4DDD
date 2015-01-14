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
        public Mvc4DDDContext(String conn)
            : base(conn) //"Mvc4DDD"
        {
            // The default connection String (Mvc4DDD) is saved on Mvc4DDD.Administration Web.config.
        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing some dangerous conventions.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Changing the convention for String types.
            modelBuilder.Properties<String>()
                .Configure(p => p.HasMaxLength(1024));

            modelBuilder.Configurations.Add(new CompanyConfiguration());

            /*************/

            // Save AdditionalPhones as a JSON object 
           /* modelBuilder.ComplexType<AdditionalPhonesList>()
                .Property(p => p.Serialized)
                .HasColumnName("AdditionalPhones");*/

            
        }

    }
}
