using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Domain.Entities;

namespace Mvc4DDD.Application.Interfaces
{
    public interface ICompanyAppService : IAppServiceBase<Company>
    {
        IEnumerable<String> GetCountries();

        Dictionary<String, String> GetCategories();

        IEnumerable<Company> GetByLocation(String location);

        IEnumerable<Company> GetByCategory(String categoryCode);
    }
}
