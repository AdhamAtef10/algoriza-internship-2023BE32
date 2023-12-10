using FluentNHibernate.Conventions.Inspections;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class ApplicationUser:BaseEntity
    {
        public string FullName { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public AccountType AccountType { get; set; }
        public int UserId { get; set; }
        [ForeignKey("DoctorId")]       
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("PatientId")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }              
        public virtual List<Booking> Bookings { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
        public virtual ICollection<Request>? Requests { get; set; }
    }
}
