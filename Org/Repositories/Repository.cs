using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Org.Common.Repositories;
using Org.Common.Services;

namespace Org.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OrgContext _context;
        protected readonly IUpdateService _updateService;

        protected readonly IDbSet<T> Items;

        protected Repository(OrgContext context, IUpdateService updateService)
        {
            _context = context;
            _updateService = updateService;
            Items = _context.Set<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            var result = Items.AsQueryable();

            if (predicate != null)
            {
                result = result.Where(predicate);
            }

            return result.ToList();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Items
                .FirstOrDefault(predicate);
        }

        public virtual T Add(T product)
        {
            var result = Items.Add(product);
            _context.SaveChanges();

            return result;
        }

        public virtual void Delete(T product)
        {
            Items.Remove(product);
            _context.SaveChanges();
        }
    }
}