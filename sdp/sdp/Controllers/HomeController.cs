using SDP.DAL;
using SDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDP.Controllers
{
   
    public class HomeController : Controller
    {
        private SDPContext db = new SDPContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View(db.Events.ToList());
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}