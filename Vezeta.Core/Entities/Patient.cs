using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class Patient:BaseEntity
    {
        public string Image { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DoctorName { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<DiscountCode> Discounts { get; set; } = new HashSet<DiscountCode>();
        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
}