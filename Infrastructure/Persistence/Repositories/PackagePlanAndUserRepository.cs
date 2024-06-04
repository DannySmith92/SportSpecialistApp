using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class PackagePlanAndUserRepository : Repository<PackagePlanAndUser>, I_PackagePlanAndUserRepository
    {
        private readonly DataContext _context;

        public PackagePlanAndUserRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<PackagePlanAndUser> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<PackagePlanAndUser> GetAllByUserId(string UserId)
        {
            return null;
        }
        public IQueryable<PackagePlanAndUser> GetAllByTrainerId(string TrainerId)
        {
            return null;
        }
        public IQueryable<PackagePlanAndUser> GetAllDisciplineByDisciplineId(string PackagePlanId)
        {
            return null;
        }
    }
}
