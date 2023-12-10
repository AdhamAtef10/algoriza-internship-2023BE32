using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Specifications;

namespace Vezeta.Core.Repositories
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync(); 
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecifications<T> spec);
        Task<T> GetByIdWithSpecAsync(ISpecifications<T> spec);
        Task<int> GetCountWithSpecAsync(ISpecifications<T> spec);
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
