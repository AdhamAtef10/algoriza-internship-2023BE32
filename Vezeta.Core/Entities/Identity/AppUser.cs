using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Enum;

namespace Vezeta.Core.Entities.Identity
{
    public class AppUser:IdentityUser
    {
        public string DisplayName { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "First name must not exceed 15 characters.")]
        [MinLength(5, ErrorMessage = "First name must not be less than 5 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Last name must not exceed 15 characters.")]
        [MinLength(5, ErrorMessage = "Last name must not be less than 5 characters.")]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string? Image { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
