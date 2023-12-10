using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Repositories;
using Vezeta.Core.Specifications;
using Vezeta.Repository.Data;

namespace Vezeta.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _appContext;

        public GenericRepository(ApplicationContext appContext) //ASK CLR for creating object from applicationContext  
        {
            _appContext = appContext;
        }
      
        public async Task<IReadOnlyList<T>> GetAllAsync()
          => await _appContext.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id)
           => await _appContext.Set<T>().FindAsync(id);

        public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecifications<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }
        public async Task<T> GetByIdWithSpecAsync(ISpecifications<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<int> GetCountWithSpecAsync(ISpecifications<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }
        private IQueryable<T> ApplySpecification(ISpecifications<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_appContext.Set<T>(), spec);
        }
        public async Task Add(T entity)
        {
            await _appContext.Set<T>().AddAsync(entity);
        }

        public async void Update(T entity)
        {
            _appContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            _appContext.Set<T>().Remove(entity);
        }
    }
}
