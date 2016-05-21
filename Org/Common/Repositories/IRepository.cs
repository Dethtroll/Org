using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Org.Common.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null);

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        T Add(T product);

        void Delete(T product);
    }
}