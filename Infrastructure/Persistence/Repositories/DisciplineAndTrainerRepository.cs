using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class DisciplineAndTrainerRepository : Repository<DisciplineAndTrainer>, I_DisciplineAndTrainerRepository
    {
        private readonly DataContext _context;

        public DisciplineAndTrainerRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<DisciplineAndTrainer> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<DisciplineAndTrainer> GetAllByUserId(string UserId)
        {
            return null;
        }
        public IQueryable<DisciplineAndTrainer> GetAllByDisciplineId(string DisciplineId)
        {
            return null;
        }
    }
}
