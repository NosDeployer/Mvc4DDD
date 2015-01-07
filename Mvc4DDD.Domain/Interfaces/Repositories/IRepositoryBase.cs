using System.Collections.Generic;

namespace Mvc4DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Dispose();
    }
}
