using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Requirement
    {
        [Key]
        public int RequirementId { get; set; }
        public int TotalRequirement { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? TechnologyId { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual Department RequirementCreatedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public virtual Department RequirementModifiedBy { get; set; }
        [ForeignKey("TechnologyId")]
        public virtual Technology RequiredTechnology { get; set; }
    }
}