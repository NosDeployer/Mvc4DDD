using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.Domain.Interfaces.Repositories;
using Mvc4DDD.Domain.Interfaces.Services;

namespace Mvc4DDD.Domain.Services
{
    public class CompanyService : ServiceBase<Company>, ICompanyService
    {
        private ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
            :base(companyRepository)
        {
            _companyRepository = companyRepository;
        }

        /// <summary>
        /// Returns all distinct cities.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetCities()
        {
            return _companyRepository.GetCities();
        }

        /// <summary>
        /// Returns a dictionary with Category's code and Category's name.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetCategories()
        {
            return _companyRepository.GetCategories();
        }

        /// <summary>
        /// Returns all companies based on their city.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public IEnumerable<Company> GetByLocation(string location)
        {
            return _companyRepository.GetByLocation(location);
        }

        /// <summary>
        /// Returns all companies based on their category.
        /// </summary>
        /// <param name="categoryCode"></param>
        /// <returns></returns>
        public IEnumerable<Company> GetByCategory(string categoryCode)
        {
            return _companyRepository.GetByCategory(categoryCode);
        }
    }
}
