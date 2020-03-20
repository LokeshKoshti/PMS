using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Holiday
    {
        [Key]
        public int HolidayId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Title { get; set; }
        public int? CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual Department HolidayCreatedBy { get; set; }
    }
}