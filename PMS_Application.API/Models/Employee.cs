using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Employee
    {
        [Key]
        public int Emp_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string Contact { get; set; }
        public int Experiance { get; set; }
        public DateTime DOB { get; set; }
        public byte QualificationId { get; set; }
        public byte[] Image { get; set; }
        public DateTime Joining_Date { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? ReportingId { get; set; }
        public int? DepartmentId { get; set; }
        public int? TechnologyId { get; set; }
        //Foreign Key
        [ForeignKey("ReportingId")]
        public virtual Employee ReportingAuthority { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department DeptId { get; set; }

        [ForeignKey("TechnologyId")]
        public virtual Technology TechId { get; set; }
    }
}