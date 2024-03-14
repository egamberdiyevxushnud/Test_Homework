
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using Test.Api.Data;
using Test.Api.Entity.Car;

namespace Test.Api.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> Create(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<bool> Delete(Expression<Func<T, bool>> expression)
        {
            var result = await _dbSet.FirstOrDefaultAsync(expression);

            if(result == null)
            {
                return false;
            }

            _context.Remove(result);
            _context.SaveChangesAsync();

            return true;

            
        }

        public async Task<List<T>> GetAll()
        {
            var result = await _dbSet.ToListAsync();
            return result;
        }

        public async Task<T> GetByAny(Expression<Func<T, bool>> expression)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(expression);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public async Task<T> Update(T entity)
        {
            var result = _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
