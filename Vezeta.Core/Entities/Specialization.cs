using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Core.Entities
{
    public class Specialization:BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public  int NumOfRequests { get; set; }
        public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();     
    }
}