using Domain.Entities;
namespace Application.Repositories
{
    public interface I_PackagePlanAndUserRepository : I_Repository<PackagePlanAndUser>
    {
        public IQueryable<PackagePlanAndUser> GetAllWithEntities();
        public IQueryable<PackagePlanAndUser> GetAllByUserId(string UserId);
        public IQueryable<PackagePlanAndUser> GetAllByTrainerId(string TrainerId);
        public IQueryable<PackagePlanAndUser> GetAllDisciplineByDisciplineId(string PackagePlanId);
    }
}
