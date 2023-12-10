using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class DiscountCode:BaseEntity
    {
        public string Code { get; set; }
        public int NumRequests { get; set; }
        public DiscountType Type { get; set; }
        public decimal Value { get; set; }
        public ICollection<Patient> patients { get; set; } = new HashSet<Patient>();
    }
}