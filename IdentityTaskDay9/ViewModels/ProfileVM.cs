using System.ComponentModel.DataAnnotations;

namespace IdentityTaskDay9.ViewModels
{
    public class ProfileVM
    {
        [Key]
        public string userName { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
    }
}
