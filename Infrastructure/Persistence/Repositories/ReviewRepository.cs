using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class ReviewRepository : Repository<Review>, I_ReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<Review> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<Review> GetAllByTrainerId(string TrainerId)
        {
            return null;
        }
        public IQueryable<Review> GetAllByCustomerId(string CustomerId)
        {
            return null;
        }
    }
}


