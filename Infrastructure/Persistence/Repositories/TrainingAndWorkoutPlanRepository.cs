using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class TrainingAndWorkoutPlanRepository : Repository<TrainingAndWorkoutPlan>, I_TrainingAndWorkoutPlanRepository
    {
        private readonly DataContext _context;

        public TrainingAndWorkoutPlanRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<TrainingAndWorkoutPlan> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<DisciplineAndTrainer> GetAllByTrainingId(string TrainingId)
        {
            return null;
        }
        public IQueryable<DisciplineAndTrainer> GetAllByWorkoutPlanId(string WorkoutPlanId)
        {
            return null;
        }
        public IQueryable<DisciplineAndTrainer> GetAllByDisciplineId(string DisciplineId)
        {
            return null;
        }
    }
}
