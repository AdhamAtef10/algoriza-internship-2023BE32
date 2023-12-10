using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Repository.Data
{
    public class ApplicationContext:DbContext
    {
       public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Booking>(B =>
            {               
                B.HasOne(P => P.PatientName).WithMany(s => s.Bookings)
                .HasForeignKey(s => s.PatientId).OnDelete(DeleteBehavior.Restrict);

                B.HasOne(s => s.Doctor).WithMany(s => s.Bookings)
                .HasForeignKey(s => s.DoctorId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Request>(R =>
            {
                R.HasOne(B => B.Booking).WithOne(R => R.NumOfRequest)
                .HasForeignKey<Booking>(B => B.NumOfRequestId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ApplicationUser>(A =>
            {
                A.HasOne(A => A.Doctor).WithMany(D => D.ApplicationUsers)
                .HasForeignKey(A => A.DoctorId).OnDelete(DeleteBehavior.Restrict);

                A.HasOne(A => A.Patient).WithMany(P => P.ApplicationUsers)
                .HasForeignKey(A => A.PatientId).OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Times> Times { get; set; }
    }
}
