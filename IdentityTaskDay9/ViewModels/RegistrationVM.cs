using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IdentityTaskDay9.ViewModels
{
    public class RegistrationVM
    {
        [Key]
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Sex { get; set; }
        public string? Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
