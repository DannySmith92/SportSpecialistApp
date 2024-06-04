using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
    {
    public class Repository<T> : I_Repository<T> where T : class, I_Entity
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(string Id)
        {

            var model = await _context.Set<T>()
                 .AsNoTracking()
                 .FirstOrDefaultAsync(e => e.Id == Id);

            if (model != null)
            {
                return model;
            }
            else
            {
                return default;

            }
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(string Id)
        {
            var gettedElement = await GetByIdAsync(Id);

            if (gettedElement != null)
            {
                _context.Set<T>().Remove(gettedElement);
                return true;
            }
            else
            {

                return false; ;
            }
        }

    }
}

