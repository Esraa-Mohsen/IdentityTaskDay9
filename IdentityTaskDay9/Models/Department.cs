using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LayersAndIdentity.Models
{
    public class Department
    {
        [Key]
        public int Number { get; set; }
        public string? Name { get; set; }
        public virtual List<DepartmentLocation>? DepartmentLocations { get; set; }
        public virtual List<Project>? Projects { get; set; }

        // NP and FK for relation (manege 1 to 1) Employee => Department
        [ForeignKey("EmployeeManege")]
        public string? mngrSSN { get; set; }
        public virtual ApplicationUser? EmployeeManege { get; set; }

        // NP and FK for relation (manege 1 to 1) Employee => Department
        public virtual List<ApplicationUser>? EmployeesWork { get; set; }

        [NotMapped]
        public int numberOfLocations { get; set; }
    }
}
