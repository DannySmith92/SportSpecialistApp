using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment : I_Entity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime Data { get; set; } = DateTime.Now;
        public string StatusAppointment { get; set; } = string.Empty;
        public string Note {  get; set; } = string.Empty;   
        public virtual User? Trainer { get; set; }
        public string TrainerId { get; set; } = string.Empty;
        public virtual User? Customer { get; set; }
        public string CustomerId { get; set; } = string.Empty;
    }
}
