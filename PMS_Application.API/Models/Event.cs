using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual Department EventCreatedBy { get; set; }
        
    }
}