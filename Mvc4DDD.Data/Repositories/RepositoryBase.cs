using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4DDD.Domain.Interfaces;
using Mvc4DDD.Data.Context;
using System.Data.Entity;
using Mvc4DDD.Domain.Interfaces.Repositories;

namespace Mvc4DDD.Data.Repositories
{
    /// <summary>
    /// Just the default CRUD.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected Mvc4DDDContext Db;

        public RepositoryBase(String conn)
        {
            Db = new Mvc4DDDContext(conn);
        } 

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
