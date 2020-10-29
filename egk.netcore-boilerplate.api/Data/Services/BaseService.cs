using egk.netcore_boilerplate.api.Data.Repositories.Contracts;
using egk.netcore_boilerplate.api.Data.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Services
{
    public class BaseService<TEntity, TContext> : IBaseService<TEntity, TContext> where TEntity : class where TContext : IDBContext, new()
    {
        private readonly IGenericRepository<TEntity, TContext> genericRepository;

        public BaseService(IGenericRepository<TEntity, TContext> _genericRepository)
        {
            genericRepository = _genericRepository;
        }


        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            return genericRepository.Get(filter, orderBy, includeProperties);
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            return await genericRepository.GetAsync(filter, orderBy, includeProperties);
        }

        public TEntity GetByID(object id)
        {
            return genericRepository.GetByID(id);
        }

        public async Task<TEntity> GetByIDAsync(object id)
        {
            return await genericRepository.GetByIDAsync(id);
        }

        public virtual int CountAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return genericRepository.CountAll(includeProperties);
        }

        public virtual int Count(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return genericRepository.Count(where,includeProperties);
        }
        public async virtual Task<int> CountAllAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await genericRepository.CountAllAsync(includeProperties);
        }

        public async virtual Task<int> CountAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await genericRepository.CountAsync(where, includeProperties);
        }

        public IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return genericRepository.GetWithRawSql(query, parameters);
        }

        public async Task<IEnumerable<TEntity>> GetWithRawSqlAsync(string query, params object[] parameters)
        {
            return await genericRepository.GetWithRawSqlAsync(query, parameters);
        }

        public TEntity Insert(TEntity entity)
        {
            return genericRepository.Insert(entity);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            return await genericRepository.InsertAsync(entity);
        }

        public bool Update(TEntity entityToUpdate)
        {
            return genericRepository.Update(entityToUpdate);
        }

        public async Task<bool> UpdateAsync(TEntity entityToUpdate)
        {
            return await genericRepository.UpdateAsync(entityToUpdate);
        }
        public bool Delete(TEntity entityToDelete)
        {
            return genericRepository.Delete(entityToDelete);
        }

        public bool Delete(object id)
        {
            return genericRepository.Delete(id);
        }

        public async Task<bool> DeleteAsync(TEntity entityToDelete)
        {
            return await genericRepository.DeleteAsync(entityToDelete);
        }

        public async Task<bool> DeleteAsync(object id)
        {
            return await genericRepository.DeleteAsync(id);
        }
    }
}
