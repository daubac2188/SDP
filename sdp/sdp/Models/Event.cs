using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDP.Models
{
    public class Event
    {
        public int ID { get; set; }

        [Required]
        [Display(Name="Event Name")]
        public string Name { get; set; }
        public string Body { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string Date { get; set; }
        public string Image { get; set; }
        [Required]
        public string Venue { get; set; }


        public virtual ICollection<Event> Events { get; set; }
    }
}