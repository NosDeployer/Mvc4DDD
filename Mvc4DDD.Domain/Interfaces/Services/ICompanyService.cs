using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Domain.Entities;

namespace Mvc4DDD.Domain.Interfaces.Services
{
    public interface ICompanyService : IServiceBase<Company>
    {
        /// <summary>
        /// Returns all distinct countries.
        /// </summary>
        /// <returns></returns>
        IEnumerable<String> GetCountries();

        /// <summary>
        /// Returns a dictionary with Category's code and Category's name.
        /// </summary>
        /// <returns></returns>
        Dictionary<String, String> GetCategories();

        /// <summary>
        /// Returns all companies based on their country.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        IEnumerable<Company> GetByLocation(String location);

        /// <summary>
        /// Returns all companies based on their category.
        /// </summary>
        /// <param name="categoryCode"></param>
        /// <returns></returns>
        IEnumerable<Company> GetByCategory(String categoryCode);
    }
}
