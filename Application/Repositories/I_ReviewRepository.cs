using Domain.Entities;
namespace Application.Repositories
{
    public interface I_ReviewRepository : I_Repository<Review>
    {
        public IQueryable<Review> GetAllWithEntities();
        public IQueryable<Review> GetAllByTrainerId(string TrainerId);
        public IQueryable<Review> GetAllByCustomerId(string CustomerId);
    }
}


