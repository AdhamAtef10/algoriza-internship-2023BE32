using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Core.Specifications
{
    public class BookingWithSpecification : BaseSpecifications<Booking>
    {
        public BookingWithSpecification(BookingSpecParams specParams)
          : base(B =>
             (specParams.PageSize==specParams.PageSize && specParams.PageIndex==specParams.PageIndex) &&
             (!specParams.DoctorId.HasValue || B.DoctorId == specParams.DoctorId.Value) &&
             (!specParams.Date.HasValue || B.Appointment.Date == specParams.Date.Value)
          )
        {
            ApplyPagination(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);

        }
        public BookingWithSpecification(int id) : base(B => B.Id == id)
        {
        }
    }
}