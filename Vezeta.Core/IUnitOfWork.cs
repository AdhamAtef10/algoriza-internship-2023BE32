using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Repositories;

namespace Vezeta.Core
{
    public interface IUnitOfWork : IAsyncDisposable
    {       
        IGenericRepository<TEntity>? Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Complete();

    }
}
