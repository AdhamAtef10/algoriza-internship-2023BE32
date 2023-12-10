using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeta.Core.Entities
{
    public class DoctorSpecialization:BaseEntity
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
    }
}
