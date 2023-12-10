using Vezeta.Core.Entities.Enum;
using Vezeta.Core.Entities;

namespace Vezeta.APIs.Dtos
{
    public class BookingToReturnDto
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public decimal Price { get; set; }
        public int DiscountCodeId { get; set; }
        public DiscountCode DiscountCode { get; set; }
        public decimal FinalPrice { get; set; }
        public BookingStatus Status { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
