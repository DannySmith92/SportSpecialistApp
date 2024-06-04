using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class PackagePlanRepository : Repository<PackagePlan>, I_PackagePlanRepository
    {
        private readonly DataContext _context;

        public PackagePlanRepository(DataContext context) : base(context)
        {
            _context = context;

        }
    }
}
