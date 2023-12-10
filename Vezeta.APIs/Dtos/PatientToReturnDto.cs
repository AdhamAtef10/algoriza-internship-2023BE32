using System.ComponentModel.DataAnnotations.Schema;
using Vezeta.Core.Entities;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.APIs.Dtos
{
    public class PatientToReturnDto
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
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<DiscountCode> Discounts { get; set; } = new HashSet<DiscountCode>();
        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
}
