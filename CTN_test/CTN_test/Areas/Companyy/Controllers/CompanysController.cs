using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTN_test.Areas.Companyy.Controllers
{
    public class CompanysController : Controller
    {
        // GET: Companyy/Companys
        public ActionResult CompanyIndex()
        {
            return View();
        }

        public ActionResult CompanyInfo() 
        {
            return View();
        }

        public ActionResult CompanGLgzjh() 
        {
            return View();
        }
    }
}