using Application.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;
namespace Infrastructure.Persistence.Repositories
{
    public class CouponRepository : Repository<Coupon>, I_CouponRepository
    {
        private readonly DataContext _context;

        public CouponRepository(DataContext context) : base(context)
        {
            _context = context;

        }
        public IQueryable<Coupon> GetAllCouponByUserId(string UserId)
        {
            return null;
        }


    }
}
