using System.Collections.Generic;
using SharedKernel.BaseObjects;

namespace Domain.Contracts.Repositories.Base
{
    public interface IRepositoryBase<T> where T: Entity
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);

    }
}
