using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Application.Interfaces;
using Mvc4DDD.Domain.Interfaces.Services;

namespace Mvc4DDD.Application.Apps
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _appServiceBase;

        public AppServiceBase(IServiceBase<TEntity> appServiceBase)
        {
            _appServiceBase = appServiceBase;
        }

        public void Add(TEntity obj)
        {
            _appServiceBase.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _appServiceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _appServiceBase.Remove(obj);
        }

        public TEntity GetById(int id)
        {
            return _appServiceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _appServiceBase.GetAll();
        }

        public void Dispose()
        {
            _appServiceBase.Dispose();
        }
    }
}
