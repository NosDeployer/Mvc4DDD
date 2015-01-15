﻿using System;
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

        /// <summary>
        /// Returns all distinct countries.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetCountries()
        {
            return Db.Companies.Select(c => c.County).Distinct().ToList();
        }

        /// <summary>
        /// Returns a dictionary with Category's code and Category's name.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetCategories()
        {
            return Db.Companies.Select(c => new {Category = c.CategoryCode, Name = c.CategoryName})
                .Distinct()
                .ToDictionary(arg => arg.Category, arg => arg.Name);
        }

        /// <summary>
        /// Returns all companies based on their country.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public IEnumerable<Company> GetByLocation(string location)
        {
            return Db.Companies.Where(c => c.County.Equals(location)).ToList();
        }

        /// <summary>
        /// Returns all companies based on their category.
        /// </summary>
        /// <param name="categoryCode"></param>
        /// <returns></returns>
        public IEnumerable<Company> GetByCategory(string categoryCode)
        {
            return Db.Companies.Where(c => c.CategoryCode.Equals(categoryCode));
        }
    }
}
