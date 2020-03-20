using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Technology
    {
        [Key]
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual Department DepartmentCreatedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public virtual Department DepartmentModifiedBy { get; set; }
    }
}