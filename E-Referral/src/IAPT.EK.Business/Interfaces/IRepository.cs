using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
   
    public interface IRepository<TEntity> : IDisposable where TEntity: Entity
    {
        Task<bool> HasAnyAsync(Guid id);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task InsertEntityAsync(TEntity entity);
       
        Task UpdateEntityAsync(TEntity entity);

        Task DeleteEntityAsync(Guid id);

        Task<int> SaveChanges();

    }
}
