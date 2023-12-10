using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Repository.Data.Config
{
    public class DoctorConfigurations : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(D => D.Price).HasColumnType("decimal(18,2)");       
            
            builder.HasMany(D => D.DoctorSpecializations).WithOne(DS=>DS.Doctor)
                .HasForeignKey(DS => DS.DoctorId);

            builder.HasMany(D => D.Appointments).WithOne(A=>A.Doctor)
                .HasForeignKey(A=>A.DoctorId);

            builder.HasOne(D => D.Specialization).WithMany(S => S.Doctors)
                .HasForeignKey(D => D.SpecializationId);
            //builder.HasOne(D => D.ApplicationUser).WithOne(A=>A.Doctor)
            //    .HasForeignKey<ApplicationUser>(A=>A.DoctorId)
            //    .OnDelete(DeleteBehavior.Cascade);         
        }
    }
}
