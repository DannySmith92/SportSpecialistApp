using Domain.Entities;


namespace Application.Repositories
{
    public interface I_OrderRepository : I_Repository<Order>
    {
        public IQueryable<Order> GetAllWithEntities();
        public IQueryable<Order> GetAllWithEntitiesByUserId(string UserId);
        public IQueryable<Order> GetAllWithEntitiesByPaymentId(string PaymentId);
    }
}
