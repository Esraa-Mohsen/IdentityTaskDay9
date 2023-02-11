using System.ComponentModel.DataAnnotations;

namespace IdentityTaskDay9.ViewModels
{
    public class LoginVM
    {
        [Key]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
