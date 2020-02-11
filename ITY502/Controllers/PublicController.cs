using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITY502.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public
        public ActionResult PublicHomePage()
        {
            return View();
        }
    }
}