using System.ComponentModel.DataAnnotations;

namespace Vezeta.APIs.Helpers
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm Password is Required ")]
        [Compare("NewPassword", ErrorMessage = "Confirm Password Doesn't match Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
    }
}
