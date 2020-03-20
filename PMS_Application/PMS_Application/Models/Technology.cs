using System;
using System.Collections.Generic;
using System.Text;

namespace PMS_Application.Models
{
    public class Technology
    {
        //[Key]
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int DepartmentId { get; set; }

        //[ForeignKey("DepartmentId")]
        public virtual Department DeptId { get; set; }
    }
}
