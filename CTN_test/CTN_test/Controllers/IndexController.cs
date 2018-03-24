using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTN_test.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult jobs() 
        {
            return View();
        }

        public ActionResult resumes() 
        {
            return View();
        }

        public ActionResult about() 
        {
            return View();
        }

        public ActionResult contact() 
        {
            return View();
        }
    }
}