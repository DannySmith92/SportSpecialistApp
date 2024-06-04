using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class WorkoutPlanRepository : Repository<WorkoutPlan>, I_WorkoutPlanRepository
    {
        private readonly DataContext _context;

        public WorkoutPlanRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<WorkoutPlan> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<WorkoutPlan> GetAllCouponByTrainerId(string TrainerId)
        {
            return null;
        }
    }
}
