namespace Vezeta.APIs.Dtos
{
    public class DoctorToAddDto
    {
        public IFormFile Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int SpecializationId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
