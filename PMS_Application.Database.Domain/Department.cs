using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_Application.Database.Domain
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        
        public string DepartmentName { get; set; }
    }
}
