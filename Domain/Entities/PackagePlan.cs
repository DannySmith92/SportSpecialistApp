using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PackagePlan : I_Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public float Price { get; set; } = 0;
        public int MaxTrainingDays { get; set; } = 0;

    }
}
