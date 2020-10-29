using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Repositories.Contracts
{
    public interface IGenericRepository<TEntity, TContext> where TEntity : class where TContext : IDBContext, new()
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetByID(object id);
        Task<TEntity> GetByIDAsync(object id);
        int CountAll(params Expression<Func<TEntity, object>>[] includeProperties);
        int Count(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties); 
        Task<int> CountAllAsync(params Expression<Func<TEntity, object>>[] includeProperties);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);
        IEnumerable<TEntity> GetWithRawSql(string query,params object[] parameters);
        Task<IEnumerable<TEntity>> GetWithRawSqlAsync(string query,params object[] parameters);
        TEntity Insert(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);
        bool Update(TEntity entityToUpdate);
        Task<bool> UpdateAsync(TEntity entityToUpdate);
        bool Delete(TEntity entityToDelete);
        Task<bool> DeleteAsync(TEntity entityToDelete);
        bool Delete(object id);
        Task<bool> DeleteAsync(object id);


    }
}
