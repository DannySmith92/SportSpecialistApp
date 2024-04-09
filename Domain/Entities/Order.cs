using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Domain.Entities
{
    public  class Order : I_Entity
    {
        [Key]
        public string  Id { get; set; } = Guid.NewGuid().ToString();

        public int OrderNumber { get; set; } = 0;
        public decimal Tax { get; set; } = 0;
        public string? Note { get; set; }
        public decimal TotalPrice { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
        public DateTime OrderData { get; set; } = new DateTime();
        public virtual User User { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual Payment Payment { get; set; } = null!;
        public int PaymentId { get; set; } = 0;
        public virtual Coupon? Coupon { get; set; } = null!;
        public int? CouponId { get; set; } = 0;
        public string QRCodeId { get; set; } = string.Empty;
    }
}
