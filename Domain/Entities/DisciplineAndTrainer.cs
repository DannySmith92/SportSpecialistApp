using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DisciplineAndTrainer : I_Entity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual Discipline Discipline { get; set; } = null!;
        public string DisciplineId { get; set; } = string.Empty;

        public virtual User Trainer { get; set; } = null!;
        public string TrainerId { get; set; } = string.Empty;
    }
}
    

