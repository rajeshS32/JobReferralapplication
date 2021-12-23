using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobReferralapplication.Models;

namespace JobReferralapplication.Controllers
{
    public class Login1Controller : Controller
    {
        private JobreferenceEntities2 db = new JobreferenceEntities2();

        // GET: Login1
        public ActionResult Index()
        {
            return View(db.referenceregs.ToList());
        }

        

        // GET: Login1/Create
        public ActionResult login()
        {
            return View();
        }

        // POST: Login1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login([Bind(Include = "username,password")] referencereg referencereg)
        {
            if (ModelState.IsValid)
            {
                if(referencereg.username == "user1" && referencereg.password == "user@123")
                {
                    return RedirectToAction("index", "jobdescriptions");
                }
                else
                {
                    return RedirectToAction("Create", "referenceregs");
                }
                db.referenceregs.Add(referencereg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referencereg);
        }

      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
