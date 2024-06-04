using Domain.Entities;
namespace Application.Repositories
{
    public interface I_TrainingAndWorkoutPlanRepository : I_Repository<TrainingAndWorkoutPlan>
    {
        public IQueryable<TrainingAndWorkoutPlan> GetAllWithEntities();
        public IQueryable<DisciplineAndTrainer> GetAllByTrainingId(string TrainingId);
        public IQueryable<DisciplineAndTrainer> GetAllByWorkoutPlanId(string WorkoutPlanId);
        public IQueryable<DisciplineAndTrainer> GetAllByDisciplineId(string DisciplineId);
    }
}
