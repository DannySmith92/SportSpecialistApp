using Domain.Entities;
namespace Application.Repositories
{
    public interface I_TrainingRepository : I_Repository<Training>
    {
        public IQueryable<Training> GetAllWithEntities();
        public IQueryable<Training> GetAllCouponByTrainerId(string TrainerId);
    }
}
