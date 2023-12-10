using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Vezeta.Core.Entities.Enum;
using Vezeta.Core.Entities;

namespace Vezeta.APIs.Dtos
{
    public class DoctorToReturnDto
    {
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public int DoctorSpecializationId { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Patient> PatientsName { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        public virtual List<DoctorSpecialization> DoctorSpecializations { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
    }
}
