using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate.Mapping.ByCode.Impl;
using System.Numerics;
using Vezeta.APIs.Dtos;
using Vezeta.APIs.Errors;
using Vezeta.APIs.Helpers;
using Vezeta.Core;
using Vezeta.Core.Entities;
using Vezeta.Core.Repositories;
using Vezeta.Core.Specifications;

namespace Vezeta.APIs.Controllers
{
    public class DoctorController : ApiBaseController
    {       
        private readonly IUnitOfWork _unitOfWork;

        public DoctorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<Pagination<DoctorToReturnDto>>> GetAllDoctors([FromQuery] DoctorSpecParams specParams)
        {
            var spec = new DoctorWithSpecializationSpecification(specParams);
            var doctors = await _unitOfWork.Repository<Doctor>().GetAllWithSpecAsync(spec);
            if (doctors is null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(new Pagination<DoctorToReturnDto>(specParams.PageIndex, specParams.PageSize));
        }

        [ProducesResponseType(typeof(DoctorToReturnDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<Doctor>>> GetDoctorById(int id)
        {
            var spec = new DoctorWithSpecializationSpecification(id);
            var doctor = await _unitOfWork.Repository<Doctor>().GetByIdWithSpecAsync(spec);
            if (doctor is null) return NotFound(new ApiResponse(404));
            return Ok(doctor);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(DoctorToReturnDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DoctorToReturnDto>> EditDoctor(int id, [FromBody] DoctorToUpdateDto doctorToUpdateDto)
        {
            var existingDoctor = await _unitOfWork.Repository<Doctor>().GetByIdAsync(id);

            if (existingDoctor is null)
            {
                return NotFound(new ApiResponse(404));
            }

            existingDoctor.FirstName = doctorToUpdateDto.FirstName;
            existingDoctor.LastName = doctorToUpdateDto.LastName;
            existingDoctor.Email = doctorToUpdateDto.Email;
            existingDoctor.Phone = doctorToUpdateDto.Phone;
            //existingDoctor.SpecializationId = doctorToUpdateDto.SpecializationId;
            existingDoctor.Gender=doctorToUpdateDto.Gender;
            existingDoctor.DateOfBirth = doctorToUpdateDto.DateOfBirth;

            var updatedDoctorToReturnDto = new DoctorToReturnDto
            {
                Id = existingDoctor.Id,
                FirstName = existingDoctor.FirstName,
                LastName = existingDoctor.LastName,
                Email= existingDoctor.Email,
                Phone= existingDoctor.Phone,
                //SpecializationId=existingDoctor.SpecializationId,
                Gender=existingDoctor.Gender,
                DateOfBirth=existingDoctor.DateOfBirth,
            };
            return Ok(updatedDoctorToReturnDto);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctorToDelete = await _unitOfWork.Repository<Doctor>().GetByIdAsync(id);

            if (doctorToDelete is null)
            {
                return NotFound(new ApiResponse(404));
            }

             _unitOfWork.Repository<Doctor>().Delete(doctorToDelete);

            return NoContent();
        }

    }
}
