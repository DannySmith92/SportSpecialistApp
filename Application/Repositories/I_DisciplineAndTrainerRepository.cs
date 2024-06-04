using Domain.Entities;
namespace Application.Repositories
{
    public interface I_DisciplineAndTrainerRepository : I_Repository<DisciplineAndTrainer>
    {
        public IQueryable<DisciplineAndTrainer> GetAllWithEntities();
        public IQueryable<DisciplineAndTrainer> GetAllByUserId(string UserId);
        public IQueryable<DisciplineAndTrainer> GetAllByDisciplineId(string DisciplineId);
    }
}
