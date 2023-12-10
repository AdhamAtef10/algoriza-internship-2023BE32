using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezeta.APIs.Dtos;
using Vezeta.APIs.Errors;
using Vezeta.APIs.Helpers;
using Vezeta.Core;
using Vezeta.Core.Entities;
using Vezeta.Core.Specifications;

namespace Vezeta.APIs.Controllers
{
    public class PatientController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<Pagination<PatientToReturnDto>>> GetAllPatients([FromQuery] PatientSpecParams specParams)
        {
            var spec = new PatientWithSpecification(specParams);
            var patients = await _unitOfWork.Repository<Patient>().GetAllWithSpecAsync(spec);
            if (patients is null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(new Pagination<PatientToReturnDto>(specParams.PageIndex, specParams.PageSize));
        }

        [ProducesResponseType(typeof(PatientToReturnDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<Patient>>> GetPatientById(int id)
        {
            var spec = new PatientWithSpecification(id);
            var patient = await _unitOfWork.Repository<Patient>().GetByIdWithSpecAsync(spec);
            if (patient is null) return NotFound(new ApiResponse(404));
            return Ok(patient);
        }
    }
}
