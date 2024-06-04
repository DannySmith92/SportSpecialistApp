using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, I_AppointmentRepository
    {
        private readonly DataContext _context;

        public AppointmentRepository(DataContext context) : base(context)
        {
            _context = context;

        }

        public IQueryable<Appointment> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<Appointment> GetAllCouponByUserId(string UserId)
        {
            return null;
        }
        public IQueryable<Appointment> GetAllCouponByTrinerId(string TrainerId)
        {
            return null;
        }
        public IQueryable<Appointment> GetAllCouponByTrinerIdAndUserId(string UserId,string TrainerId)
        {
            return null;
        }

    }
}
