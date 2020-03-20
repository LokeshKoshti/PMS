using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class TimeSheet
    {
        [Key]
        public int TimesheetId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee GetEmployee { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual Department GetDepartment { get; set; }
    }
}