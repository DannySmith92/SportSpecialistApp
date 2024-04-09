using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PackagePlanAndUser : I_Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual PackagePlan? PackagePlan { get; set; } = null;
        public string PackagePlanId { get; set; } = string.Empty;
        public virtual User? User { get; set; } = null;
        public string UserId { get; set; } = string.Empty;
        public string TrainerId { get; set; } = string.Empty;
        public int CurrentTrainingDays { get; set; } = 0;
        public bool Enabled { get; set; } = false;

    }
}
