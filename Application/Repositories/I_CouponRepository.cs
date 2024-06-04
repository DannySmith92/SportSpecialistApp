using Domain.Entities;
namespace Application.Repositories
{
    public interface I_CouponRepository : I_Repository<Coupon>
    {
        public IQueryable<Coupon> GetAllCouponByUserId(string UserId);

    }
}
