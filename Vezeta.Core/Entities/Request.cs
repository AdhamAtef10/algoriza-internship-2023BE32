using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class Request:BaseEntity
    {
        public BookingStatus Status { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
