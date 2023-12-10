using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezeta.APIs.Dtos;
using Vezeta.APIs.Helpers;
using Vezeta.Core;
using Vezeta.Core.Entities;
using Vezeta.Core.Specifications;

namespace Vezeta.APIs.Controllers
{ 
    public class BookingController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<Pagination<BookingToReturnDto>>> GetAllDoctors([FromQuery] BookingSpecParams specParams)
        {
            var spec = new BookingWithSpecification(specParams);
            var bookings = await _unitOfWork.Repository<Booking>().GetAllWithSpecAsync(spec);
            return Ok(new Pagination<BookingToReturnDto>(specParams.PageIndex, specParams.PageSize));
        }
    }
}
