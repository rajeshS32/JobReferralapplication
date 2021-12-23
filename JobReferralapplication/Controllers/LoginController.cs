using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobReferralapplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login(FormCollection collection)
        {
            string mail = collection["email"];
            string pwd = collection["pwd"];
            if (mail == "testmail@gmail.com" && pwd == "pwd123")
            {
                return RedirectToAction("Index", "Error");
            }
            else
            {
                return RedirectToAction("Index", "jobdescriptions");
            }

        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(FormCollection collection)
        //{
        //  string mail = collection["email"];
        //string pwd = collection["pwd"];
        //if(mail == "testmail@gmail.com" && pwd == "pwd123")
        //          {
        //      return RedirectToAction("Index", "Home");
        //  }
        //else
        //{
        //  return RedirectToAction("Index", "Error");
        //}
        //}
    }
}