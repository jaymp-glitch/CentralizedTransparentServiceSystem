using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITY502.Controllers
{
    public class HomeController : Controller
    {
        ITY502DBEntities dbEntities = new ITY502DBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            LoginDetail loginDetails = new LoginDetail();
            return View(loginDetails);
        }
        [HttpPost]
        public ActionResult Login(LoginDetail loginDetails)
        {
             
            if (ModelState.IsValid)
            {
                if (dbEntities.LoginDetails.Where(m => m.UserID == loginDetails.UserID && m.Password == loginDetails.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "UserID/Password not valid");
                    return View();
                }
                else
                {
                    
                    var userType = (from m in dbEntities.LoginDetails
                                    where m.UserID == loginDetails.UserID && m.Password == loginDetails.Password
                                    select m.UserType).FirstOrDefault();
                    var userName = (from m in dbEntities.LoginDetails
                                    where m.UserID == loginDetails.UserID && m.Password == loginDetails.Password
                                    select m.UserName).FirstOrDefault();
                    var userID = loginModel.UserID;
                    //var userDetails = onlineBankingEntities.LoginInfo.Where(m => m.UserID == loginModel.UserID && m.Password == loginModel.Password).Select(m => new { m.UserName, m.UserType });
                    //var userType = userDetails.Select(e => e.UserType).ToString();
                    //var userName = userDetails.Select(e => e.UserName).ToString();
                    if (userType == "Customer")
                    {
                        Session["UserID"] = userID;
                        Session["UserType"] = userType;
                        Session["UserName"] = userName;
                        return RedirectToAction("UserHomePage", "User");

                    }
                    else if (userType == "Admin")
                    {
                        Session["UserID"] = userID;
                        Session["UserType"] = userType;
                        Session["UserName"] = userName;
                        return RedirectToAction("AdminHomePage", "Admin");
                    }
                }
            }
            return View();
        }
        public ActionResult Logout()
        {

            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Session["UserID"] = null;
            Session["UserType"] = null;
            Session["UserName"] = null;
            return RedirectToAction("Index", "Home");
        } 
    }
}