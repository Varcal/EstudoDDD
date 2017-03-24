using System.Collections.Generic;
using Data.Contexts;
using Domain.Contracts.Repositories.Base;
using SharedKernel.BaseObjects;

namespace Data.Repositories.Base
{
    public class Repository<T> : IRepositoryBase<T> where T: Entity
    {
        protected EfContext _context;

        public Repository(EfContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.AddRange(entities);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _context.UpdateRange(entities);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.RemoveRange(entities);
        }

        
    }
}
