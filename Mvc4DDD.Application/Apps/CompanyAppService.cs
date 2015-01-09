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

        public IEnumerable<string> GetCountries()
        {
            return _companyService.GetCountries();
        }

        public Dictionary<string, string> GetCategories()
        {
            return _companyService.GetCategories();
        }
    }
}
