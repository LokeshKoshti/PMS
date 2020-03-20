using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        
        public string DepartmentName { get; set; }

        //public virtual ICollection<Technology> Technologies { get; set; }
    }
}