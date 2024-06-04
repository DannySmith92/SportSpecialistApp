using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class DisciplineRepository : Repository<Discipline>, I_DisciplineRepository
    {
        private readonly DataContext _context;

        public DisciplineRepository(DataContext context) : base(context)
        {
            _context = context;

        }
    }
}
