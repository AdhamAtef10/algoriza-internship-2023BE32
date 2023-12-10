using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeta.Core.Entities
{
    public class Times:BaseEntity
    {
        public int AppointmentId { get; set; }
        public DateTime Time { get; set; }
        public virtual Appointment? Appointments { get; set; }
    }
}
