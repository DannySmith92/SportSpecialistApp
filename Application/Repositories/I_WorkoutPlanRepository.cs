using Domain.Entities;
namespace Application.Repositories
{
    public interface I_WorkoutPlanRepository : I_Repository<WorkoutPlan>
    {
        public IQueryable<WorkoutPlan> GetAllWithEntities();
        public IQueryable<WorkoutPlan> GetAllCouponByTrainerId(string TrainerId);
    }
}
