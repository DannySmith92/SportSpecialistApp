using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Training : I_Entity
    {
        [Key]
        public string Id { get; set ; } = Guid.NewGuid().ToString();
        public string Name { get; set ; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ActionStep { get; set; } = string.Empty;
        public string UrlMedia { get; set; } = string.Empty;
        public virtual User? Trainer { get; set; }
        public string? TrainerId { get; set; } = Guid.NewGuid().ToString();
        public List<TrainingAndWorkoutPlan>? Trainings { get; set; }

    }
}
