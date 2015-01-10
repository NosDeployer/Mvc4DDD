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

        public IEnumerable<string> GetCountries()
        {
            return _companyRepository.GetCountries();
        }

        public Dictionary<string, string> GetCategories()
        {
            return _companyRepository.GetCategories();
        }

        public IEnumerable<Company> GetByLocation(string location)
        {
            return _companyRepository.GetByLocation(location);
        }

        public IEnumerable<Company> GetByCategory(string categoryCode)
        {
            return _companyRepository.GetByCategory(categoryCode);
        }
    }
}
