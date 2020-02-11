using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITY502.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminHomePage()
        {
            return View();
        }
    }
}