using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Payment : I_Entity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Description { get; set; }
        public string Method { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime DatePayment { get; set; } = new DateTime();

        public List<Order>? Order { get; set; }
    }

}
