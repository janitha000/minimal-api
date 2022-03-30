using Microsoft.EntityFrameworkCore;
using minimal_api.Application.Common.Interface;
using minimal_api.Core.Common;
using minimal_api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Infrastructure.Persistance
{
    public class EfCoreRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        protected virtual DbSet<TEntity> Entities { get; set; }
        public EfCoreRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public IQueryable<TEntity> Table => throw new NotImplementedException();

        public IQueryable<TEntity> TablelNoTracking => throw new NotImplementedException();

        public Task<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> Get(object id)
        {
            try
            {
                return await Entities.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await Entities.FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities;
        }

        public Task<IEnumerable<TEntity>> GetMany(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
