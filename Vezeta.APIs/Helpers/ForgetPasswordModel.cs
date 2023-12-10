using System.ComponentModel.DataAnnotations;

namespace Vezeta.APIs.Helpers
{
    public class ForgetPasswordModel
    {
        [Required(ErrorMessage = "Email is Required ")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
