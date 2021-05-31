using egk.netcore_boilerplate.api.Data.Entities.Contracts;
using egk.netcore_boilerplate.api.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity, TContext> where TEntity : class where TContext : IDBContext, new()
    {
        private TContext _context = default(TContext);
        private DbSet<TEntity> dbSet = null;
        public GenericRepository()
        {
            this._context = new TContext();
            dbSet = _context.Set<TEntity>();
        }
        public GenericRepository(TContext _context)
        {
            this._context = _context;
            dbSet = _context.Set<TEntity>();
        }
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = AsQueryable();
            query = PerformInclusions(query, null, null, null, includeProperties);
            return query.ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = AsQueryable();
            query = PerformInclusions(query, filter, orderBy, null, includeProperties);
            return await query.ToListAsync();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual async Task<TEntity> GetByIDAsync(object id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
                _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }
        public virtual int CountAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = AsQueryable();
            query = PerformInclusions(query, null, null, includeProperties);
            return query.Count();
        }

        public virtual int Count(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = AsQueryable();
            query = PerformInclusions(query, where, null, includeProperties);
            return query.Count(where);
        }
        public async virtual Task<int> CountAllAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = AsQueryable();
            query = PerformInclusions(query, null, null, includeProperties);
            return await query.CountAsync();
        }

        public async virtual Task<int> CountAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = AsQueryable();
            query = PerformInclusions(query, where, null, includeProperties);
            return await query.CountAsync(where);
        }

        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return dbSet.FromSqlRaw(query, parameters).AsNoTracking().ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> GetWithRawSqlAsync(string query, params object[] parameters)
        {
            return await dbSet.FromSqlRaw(query, parameters).AsNoTracking().ToListAsync();
        }
        public virtual TEntity Insert(TEntity entity)
        {
            dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async virtual Task<TEntity> InsertAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual bool Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            return _context.SaveChanges() > 0;

        }

        public async virtual Task<bool> UpdateAsync(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;

        }
        public virtual bool Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            return Delete(entityToDelete);
        }
        public async virtual Task<bool> DeleteAsync(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            return await DeleteAsync(entityToDelete);
        }

        public virtual bool Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            if ((entityToDelete is IAuditableEntity))
            {
                _context.Entry(entityToDelete).State = EntityState.Deleted;
            }
            else
            {
                dbSet.Remove(entityToDelete);
            }
            return _context.SaveChanges() > 0;
        }
        public async virtual Task<bool> DeleteAsync(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            if ((entityToDelete is IAuditableEntity))
            {
                _context.Entry(entityToDelete).State = EntityState.Deleted;
            }
            else
            {
                dbSet.Remove(entityToDelete);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public virtual IQueryable<TEntity> AsQueryable()
        {
            return dbSet;
        }

        private static IQueryable<TEntity> PerformInclusions(IQueryable<TEntity> query, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, IEnumerable<Expression<Func<TEntity, object>>> includePropertiesExpression = null, string includeProperties = "")
        {
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (includePropertiesExpression != null)
            {
                query = includePropertiesExpression.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }


            if (orderBy != null)
            {
                return orderBy(query).AsNoTracking();
            }
            else
            {
                return query.AsNoTracking();
            }
            //return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }



    }
}
