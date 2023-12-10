using Vezeta.Core.Entities.Enum;

namespace Vezeta.APIs.Dtos
{
    public class DoctorToUpdateDto
    {
        public IFormFile Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int SpecializationId { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
