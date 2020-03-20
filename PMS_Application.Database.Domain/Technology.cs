using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_Application.Database.Domain
{
    public class Technology
    {
        [Key]
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department DeptId { get; set; }
    }
}
