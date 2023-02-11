using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LayersAndIdentity.Models
{
    public class WorksOnProject
    {
        //need copmosit PK of This 2 FK
        public string? Hours { get; set; }

        //[Display("Name")]
        [ForeignKey("Employee")]
        public string? EmpSSN { get; set; }
        public virtual ApplicationUser? Employee { get; set; }

        [ForeignKey("Project")]
        public int projNum { get; set; }
        public virtual Project? Project { get; set; }


    }
}
