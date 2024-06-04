using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class TrainingRepository : Repository<Training>, I_TrainingRepository
    {
        private readonly DataContext _context;

        public TrainingRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<Training> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<Training> GetAllCouponByTrainerId(string TrainerId)
        {
            return null;
        }
    }
}
