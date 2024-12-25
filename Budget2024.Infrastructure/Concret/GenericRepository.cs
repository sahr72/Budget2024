using Budget2024.Core.Abstract;
using Budget2024.Infrastructure.ModelEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Infrastructure.Concret
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
           
            _dbSet = context.Set<T>();
        }

        //public Task AddAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);

            // Save changes asynchronously
            await _context.SaveChangesAsync();
        }

        //public async Task<IEnumerable<T>> GetAllAsync()
        //{
        //    //var dataBudgets = await _context.Budgets.ToListAsync();
        //    var dataBudgets = await _dbSet.ToListAsync();
        //    return _mapper.Map<IEnumerable<DomainEntities.Budget>>(dataBudgets);
        //}

        //public Task<T?> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task UpdateAsync(T entity)
        {
            // Mark the entity as modified
            _dbSet.Update(entity);

            // Save changes asynchronously to the database
            await _context.SaveChangesAsync();
        }

        public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<IEnumerable<T>> GetAllFilteredAsync(
        Dictionary<string, string>? filters = null,
        Dictionary<string, string>? sortOrder = null,
        int pageNumber = 1,
        int pageSize = 10)
        {
            IQueryable<T> query = _dbSet;

            // Apply filters
            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    var propertyName = filter.Key;
                    var value = filter.Value;

                    // Use reflection to dynamically filter based on the property name
                    query = query.Where(entity => EF.Property<string>(entity, propertyName).Contains(value));
                }
            }

            // Apply sorting
            if (sortOrder != null)
            {
                foreach (var sort in sortOrder)
                {
                    var propertyName = sort.Key;
                    var direction = sort.Value;

                    query = direction.ToLower() == "asc"
                        ? query.OrderBy(entity => EF.Property<object>(entity, propertyName))
                        : query.OrderByDescending(entity => EF.Property<object>(entity, propertyName));
                }
            }

            // Apply pagination
            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return await query.ToListAsync();
        }

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public IQueryable<T> Query()
        {
            return _dbSet.AsQueryable();
        }
    }
}
