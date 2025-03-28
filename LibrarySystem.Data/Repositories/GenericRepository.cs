﻿

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly LibraryDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(LibraryDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
