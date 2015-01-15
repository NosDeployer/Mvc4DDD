using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Application.Interfaces;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.Domain.Interfaces.Services;

namespace Mvc4DDD.Application.Apps
{
    public class CompanyAppService : AppServiceBase<Company>, ICompanyAppService
    {
        private readonly ICompanyService _companyService;

        public CompanyAppService(ICompanyService companyService)
            : base(companyService)
        {
            _companyService = companyService;
        }

        public IEnumerable<string> GetCities()
        {
            return _companyService.GetCities();
        }

        public Dictionary<string, string> GetCategories()
        {
            return _companyService.GetCategories();
        }

        public IEnumerable<Company> GetByLocation(string location)
        {
            return _companyService.GetByLocation(location);
        }

        public IEnumerable<Company> GetByCategory(string categoryCode)
        {
            return _companyService.GetByCategory(categoryCode);
        }
    }
}
