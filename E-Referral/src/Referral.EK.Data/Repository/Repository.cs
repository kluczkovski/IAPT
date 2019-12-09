using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Referral.EK.Business.Interfaces;
using Referral.EK.Business.Models;
using Referral.EK.Data.Context;

namespace Referral.EK.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity: Entity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext appDbContext) 
        {
            _context = appDbContext;
            _dbSet = _context.Set<TEntity>();
        }


        public virtual async Task<bool> HasAnyAsync(Guid id)
        {
            return await _dbSet.AnyAsync(x => x.Id == id);
        }


        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }


        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }


        public virtual async Task InsertEntityAsync(TEntity entity)
        {
            //without the DbSet
            //context.Set<TEntity>.add(entity)
            _dbSet.Add(entity);
            await SaveChanges();
        }


        public virtual async Task UpdateEntityAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }


        public virtual async Task DeleteEntityAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await SaveChanges();
        }


        public virtual async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
