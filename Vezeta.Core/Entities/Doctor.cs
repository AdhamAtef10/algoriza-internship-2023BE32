using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class Doctor:BaseEntity
    {
        [ForeignKey("UserId")]
        public string? UserId { get; set; }
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
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
        public virtual List<DoctorSpecialization> DoctorSpecializations { get; set; }
        public int AppointmentId { get; set; }
        public virtual List<Appointment> Appointments { get; set; }

    }
}

