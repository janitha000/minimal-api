using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Application.Common.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetMany(Expression<Func<T, bool>> predicate);
        Task<T> Get(object id);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(object id);
        Task<int> Count(Expression<Func<T, bool>> predicate);
        Task<int> Count();

        IQueryable<T> Table { get; }
        IQueryable<T> TablelNoTracking { get; }
    }
}
