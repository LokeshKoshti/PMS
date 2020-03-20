using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public DateTime Date { get; set; }
        public string RequestType { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee GetEmployee { get; set; }
    }
}