using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class Appointment:BaseEntity
    {
        public Day Day { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("DoctorId")]
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public bool IsBooked { get; set; }
        public virtual List<Times> Time { get; set; }   
    }
}
