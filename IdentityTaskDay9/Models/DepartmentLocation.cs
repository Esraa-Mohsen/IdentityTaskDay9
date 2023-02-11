﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LayersAndIdentity.Models
{
    public class DepartmentLocation
    {
        //need pk comp of string location, ProjNumber(fk)
        public string? Location { get; set; }

        //Fk FROM PROJECT tABLE = project.Number
        [ForeignKey("Department")]
        public int DeptNumber { get; set; }
        public virtual  Department? Department { get; set; }


    }
}
