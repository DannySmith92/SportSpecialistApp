using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Coupon : I_Entity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Code { get; set; } = string.Empty;
        public decimal Discount { get; set; } = 0;
        public string DiscountType { get; set; } = string.Empty;
        public decimal MinOrder { get; set; } = 0;
        public string? Description { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = new DateTime();
        public DateTime DateExpires { get; set; } = new DateTime();
        public bool Enabled { get; set; } = false;

        public List<Order>? Orders { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserIdUsed { get; set; } = string.Empty;

    }
}
