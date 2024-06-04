using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;


namespace Infrastructure.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>, I_OrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<Order> GetAllWithEntities()
        {
            return null;
        }
        public IQueryable<Order> GetAllWithEntitiesByUserId(string UserId)
        {
            return null;
        }
        public IQueryable<Order> GetAllWithEntitiesByPaymentId(string PaymentId)
        {
            return null;
        }
    }
}
