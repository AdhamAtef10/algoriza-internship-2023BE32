using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Repositories;
using Vezeta.Core;
using Vezeta.Repository.Data;

namespace Vezeta.Repository
{
    public class UnitOfWork : IUnitOfWork
    {                
        private readonly ApplicationContext _appContext;
        private Hashtable _repositories;

        public UnitOfWork(ApplicationContext appContext)
        {
            _appContext = appContext;
        }
        public IGenericRepository<TEntity>? Repository<TEntity>() where TEntity : BaseEntity
        {
            if (_repositories is null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repository = new GenericRepository<TEntity>(_appContext);  // Ask CLR for creating object from ApplicationContext implicitly.

                _repositories.Add(type, repository);
            }

            return _repositories[type] as IGenericRepository<TEntity>;
        }
        public async Task<int> Complete()
            => await _appContext.SaveChangesAsync();
        public async ValueTask DisposeAsync()
             => await _appContext.DisposeAsync();
    }
}
