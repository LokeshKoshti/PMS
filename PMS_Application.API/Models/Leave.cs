using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }
        public string LeaveType { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int? DepartmentId { get; set; }
        public int? TechnologyId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department DeptId { get; set; }
        [ForeignKey("TechnologyId")]
        public virtual Technology TechId { get; set; }
    }
}