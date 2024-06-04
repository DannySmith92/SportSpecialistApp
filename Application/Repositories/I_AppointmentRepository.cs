using Domain.Entities;
namespace Application.Repositories
{
    public interface I_AppointmentRepository : I_Repository<Appointment>
    {
        public IQueryable<Appointment> GetAllWithEntities();
        public IQueryable<Appointment> GetAllCouponByUserId(string UserId);
        public IQueryable<Appointment> GetAllCouponByTrinerId(string TrainerId);
        public IQueryable<Appointment> GetAllCouponByTrinerIdAndUserId(string UserId,string TrainerId);

    }
}
