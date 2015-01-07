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

    }
}
