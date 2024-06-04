    namespace Application.Repositories
    {
        public interface I_Repository<T> where T : class
        {
            IQueryable<T> GetAll();
            Task<T> GetByIdAsync(string Id);
            Task CreateAsync(T entity);
            Task UpdateAsync(T entity);
            Task<bool> SaveAllAsync();
            Task<bool> DeleteAsync(string Id);
        }
    }

