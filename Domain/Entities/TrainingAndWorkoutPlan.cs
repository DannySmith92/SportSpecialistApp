using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainingAndWorkoutPlan : I_Entity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual Training? Training { get; set; } = null;
        public string TainingId { get; set; } = string.Empty;  
        public virtual WorkoutPlan? WorkoutPlan { get; set; } = null;
        public string WorkoutPlanId { get; set; } = string.Empty;  
        public string Diffilcuty { get; set; } = string.Empty;
        public int Duration { get; set; } = 0;
        public int Repeated { get; set; } = 0;
    }
}
