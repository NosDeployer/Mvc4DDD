using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.Domain.Interfaces;
using Mvc4DDD.Domain.Interfaces.Repositories;

namespace Mvc4DDD.Data.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(string conn) : base(conn)
        {
        }

        public IEnumerable<string> GetCountries()
        {
            return Db.Companies.Select(c => c.Country).Distinct().ToList();
        }

        public Dictionary<string, string> GetCategories()
        {
            return Db.Companies.Select(c => new {Category = c.CategoryCode, Name = c.CategoryName})
                .Distinct()
                .ToDictionary(arg => arg.Category, arg => arg.Name);
        }
    }
}
