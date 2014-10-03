using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDP.Models
{
    public class Activity
    {
        public int ID { get; set; }

        [Required]
        [Display(Name="Activity Name")]
        public string Name { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }

        [Required]
        
        public int EventID { get; set; }
        public virtual Event Event { get; set; }
        
    }
}