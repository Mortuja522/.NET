using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume_Mortuja_WebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Objectives()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }


        public ActionResult Personalinfo()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }
    }
}