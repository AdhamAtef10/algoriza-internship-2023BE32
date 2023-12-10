using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities
{
    public class Booking : BaseEntity
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public decimal Price { get; set; }
        public int DiscountCodeId { get; set; }
        public DiscountCode DiscountCode { get; set; }
        public Appointment Appointment { get; set; }
        public decimal FinalPrice { get; set; }
        public BookingStatus Status { get; set; }
        public Doctor Doctor { get; set; }
        public Patient? PatientName { get; set; }
        [ForeignKey("RequestId")]
        public int NumOfRequestId { get; set; }
        public Request NumOfRequest { get; set; }
    }
}