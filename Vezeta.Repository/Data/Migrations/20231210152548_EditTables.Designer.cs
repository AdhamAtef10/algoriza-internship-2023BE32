﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vezeta.Repository.Data;

#nullable disable

namespace Vezeta.Repository.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231210152548_EditTables")]
    partial class EditTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiscountCodePatient", b =>
                {
                    b.Property<int>("DiscountsId")
                        .HasColumnType("int");

                    b.Property<int>("patientsId")
                        .HasColumnType("int");

                    b.HasKey("DiscountsId", "patientsId");

                    b.HasIndex("patientsId");

                    b.ToTable("DiscountCodePatient");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId1")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("DoctorId1")
                        .IsUnique()
                        .HasFilter("[DoctorId1] IS NOT NULL");

                    b.HasIndex("PatientId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiscountCodeId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<decimal>("FinalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumOfRequestId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("DiscountCodeId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NumOfRequestId")
                        .IsUnique();

                    b.HasIndex("PatientId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.DiscountCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumRequests")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DiscountCode");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorSpecializationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.DoctorSpecialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("DoctorSpecialization");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId1")
                        .HasColumnType("int");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfRequests")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId1");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Times", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("DiscountCodePatient", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.DiscountCode", null)
                        .WithMany()
                        .HasForeignKey("DiscountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.Patient", null)
                        .WithMany()
                        .HasForeignKey("patientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vezeta.Core.Entities.ApplicationUser", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.Doctor", "Doctor")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.Doctor", null)
                        .WithOne("ApplicationUser")
                        .HasForeignKey("Vezeta.Core.Entities.ApplicationUser", "DoctorId1");

                    b.HasOne("Vezeta.Core.Entities.Patient", "Patient")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Appointment", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.ApplicationUser", null)
                        .WithMany("Appointments")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Vezeta.Core.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Booking", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.ApplicationUser", null)
                        .WithMany("Bookings")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Vezeta.Core.Entities.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.DiscountCode", "DiscountCode")
                        .WithMany()
                        .HasForeignKey("DiscountCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.Doctor", "Doctor")
                        .WithMany("Bookings")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.Request", "NumOfRequest")
                        .WithOne("Booking")
                        .HasForeignKey("Vezeta.Core.Entities.Booking", "NumOfRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.Patient", "PatientName")
                        .WithMany("Bookings")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("DiscountCode");

                    b.Navigation("Doctor");

                    b.Navigation("NumOfRequest");

                    b.Navigation("PatientName");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Doctor", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.DoctorSpecialization", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.Doctor", "Doctor")
                        .WithMany("DoctorSpecializations")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeta.Core.Entities.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Patient", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.Doctor", null)
                        .WithMany("PatientsName")
                        .HasForeignKey("DoctorId");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Request", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.ApplicationUser", null)
                        .WithMany("Requests")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Specialization", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Times", b =>
                {
                    b.HasOne("Vezeta.Core.Entities.Appointment", "Appointments")
                        .WithMany("Time")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Bookings");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Appointment", b =>
                {
                    b.Navigation("Time");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Doctor", b =>
                {
                    b.Navigation("ApplicationUser")
                        .IsRequired();

                    b.Navigation("ApplicationUsers");

                    b.Navigation("Appointments");

                    b.Navigation("Bookings");

                    b.Navigation("DoctorSpecializations");

                    b.Navigation("PatientsName");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Patient", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Request", b =>
                {
                    b.Navigation("Booking")
                        .IsRequired();
                });

            modelBuilder.Entity("Vezeta.Core.Entities.Specialization", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
