﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDP.ViewModels
{
    public class EventView
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [AllowHtml]
        public string Body { get; set; }
        public string Date { get; set; }
    }
}