using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vezeta.Repository.Data.Migrations
{
    public partial class EditTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Doctor_DoctorId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Patient_PatientId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Specialization_SpecializeId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_ApplicationUsers_DoctorId1",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_ApplicationUsers_ApplicationUserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_DiscountCode_DiscountCodeId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Doctor_DoctorId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Patient_PatientId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Specialization_SpecializationId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialization_Doctor_DoctorId",
                table: "DoctorSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialization_Specialization_SpecializationId",
                table: "DoctorSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_Times_Appointment_AppointmentId",
                table: "Times");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_DoctorId",
                table: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_PatientId",
                table: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_SpecializeId",
                table: "ApplicationUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialization",
                table: "Specialization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_DoctorId1",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "DoctorId1",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Specialization",
                newName: "Specializations");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameColumn(
                name: "SpecializeId",
                table: "ApplicationUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Doctors",
                newName: "LastName");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_SpecializationId",
                table: "Doctors",
                newName: "IX_Doctors_SpecializationId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_PatientId",
                table: "Bookings",
                newName: "IX_Bookings_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_DoctorId",
                table: "Bookings",
                newName: "IX_Bookings_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_DiscountCodeId",
                table: "Bookings",
                newName: "IX_Bookings_DiscountCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ApplicationUserId",
                table: "Bookings",
                newName: "IX_Bookings_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_DoctorId",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId1",
                table: "ApplicationUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Specializations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId1",
                table: "Specializations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfRequests",
                table: "Specializations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoctorSpecializationId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfRequestId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specializations",
                table: "Specializations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DiscountCodePatient",
                columns: table => new
                {
                    DiscountsId = table.Column<int>(type: "int", nullable: false),
                    patientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCodePatient", x => new { x.DiscountsId, x.patientsId });
                    table.ForeignKey(
                        name: "FK_DiscountCodePatient_DiscountCode_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "DiscountCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountCodePatient_Patients_patientsId",
                        column: x => x.patientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_DoctorId",
                table: "ApplicationUsers",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_DoctorId1",
                table: "ApplicationUsers",
                column: "DoctorId1",
                unique: true,
                filter: "[DoctorId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_PatientId",
                table: "ApplicationUsers",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_DoctorId1",
                table: "Specializations",
                column: "DoctorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AppointmentId",
                table: "Bookings",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_NumOfRequestId",
                table: "Bookings",
                column: "NumOfRequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ApplicationUserId",
                table: "Appointments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCodePatient_patientsId",
                table: "DiscountCodePatient",
                column: "patientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ApplicationUserId",
                table: "Request",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Doctors_DoctorId",
                table: "ApplicationUsers",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Doctors_DoctorId1",
                table: "ApplicationUsers",
                column: "DoctorId1",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Patients_PatientId",
                table: "ApplicationUsers",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_ApplicationUsers_ApplicationUserId",
                table: "Appointments",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_ApplicationUsers_ApplicationUserId",
                table: "Bookings",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Appointments_AppointmentId",
                table: "Bookings",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_DiscountCode_DiscountCodeId",
                table: "Bookings",
                column: "DiscountCodeId",
                principalTable: "DiscountCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Doctors_DoctorId",
                table: "Bookings",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Patients_PatientId",
                table: "Bookings",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Request_NumOfRequestId",
                table: "Bookings",
                column: "NumOfRequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specializations_SpecializationId",
                table: "Doctors",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialization_Doctors_DoctorId",
                table: "DoctorSpecialization",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialization_Specializations_SpecializationId",
                table: "DoctorSpecialization",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Doctors_DoctorId1",
                table: "Specializations",
                column: "DoctorId1",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Times_Appointments_AppointmentId",
                table: "Times",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Doctors_DoctorId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Doctors_DoctorId1",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Patients_PatientId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_ApplicationUsers_ApplicationUserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_ApplicationUsers_ApplicationUserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Appointments_AppointmentId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_DiscountCode_DiscountCodeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Doctors_DoctorId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Patients_PatientId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Request_NumOfRequestId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specializations_SpecializationId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialization_Doctors_DoctorId",
                table: "DoctorSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialization_Specializations_SpecializationId",
                table: "DoctorSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Doctors_DoctorId1",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Times_Appointments_AppointmentId",
                table: "Times");

            migrationBuilder.DropTable(
                name: "DiscountCodePatient");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_DoctorId",
                table: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_DoctorId1",
                table: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_PatientId",
                table: "ApplicationUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specializations",
                table: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_Specializations_DoctorId1",
                table: "Specializations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_AppointmentId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_NumOfRequestId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ApplicationUserId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DoctorId1",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "DoctorId1",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "NumOfRequests",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DoctorSpecializationId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "NumOfRequestId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Specializations",
                newName: "Specialization");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ApplicationUsers",
                newName: "SpecializeId");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Doctor",
                newName: "FullName");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_SpecializationId",
                table: "Doctor",
                newName: "IX_Doctor_SpecializationId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_PatientId",
                table: "Booking",
                newName: "IX_Booking_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_DoctorId",
                table: "Booking",
                newName: "IX_Booking_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_DiscountCodeId",
                table: "Booking",
                newName: "IX_Booking_DiscountCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_ApplicationUserId",
                table: "Booking",
                newName: "IX_Booking_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointment",
                newName: "IX_Appointment_DoctorId");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "ApplicationUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "ApplicationUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId1",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialization",
                table: "Specialization",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_DoctorId",
                table: "ApplicationUsers",
                column: "DoctorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_PatientId",
                table: "ApplicationUsers",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_SpecializeId",
                table: "ApplicationUsers",
                column: "SpecializeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DoctorId1",
                table: "Appointment",
                column: "DoctorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Doctor_DoctorId",
                table: "ApplicationUsers",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Patient_PatientId",
                table: "ApplicationUsers",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Specialization_SpecializeId",
                table: "ApplicationUsers",
                column: "SpecializeId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_ApplicationUsers_DoctorId1",
                table: "Appointment",
                column: "DoctorId1",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_ApplicationUsers_ApplicationUserId",
                table: "Booking",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_DiscountCode_DiscountCodeId",
                table: "Booking",
                column: "DiscountCodeId",
                principalTable: "DiscountCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Doctor_DoctorId",
                table: "Booking",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Patient_PatientId",
                table: "Booking",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Specialization_SpecializationId",
                table: "Doctor",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialization_Doctor_DoctorId",
                table: "DoctorSpecialization",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialization_Specialization_SpecializationId",
                table: "DoctorSpecialization",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Times_Appointment_AppointmentId",
                table: "Times",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
