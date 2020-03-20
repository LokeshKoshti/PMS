using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class TraineeDetails
    {
        [Key]
        public int TraineeId { get; set; }
        public string Documents { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee EmployeeDetails { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department DepartmentDetails { get; set; }
    }
}