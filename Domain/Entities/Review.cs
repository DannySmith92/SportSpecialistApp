using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review : I_Entity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string? ReviewDescription { get; set; }
        public int RateReview { get; set; } = 0;
        public int RateTrainerAvailability { get; set; } = 0;
        public int RateTrainerKindness { get; set; } = 0;
        public DateTime DateReview { get; set; } = new DateTime();
        public string TrainerId { get; set; } = string.Empty;
        public virtual User User { get; set; } = null!;
        public string UserId { get; set; } = null!;
    }
}
