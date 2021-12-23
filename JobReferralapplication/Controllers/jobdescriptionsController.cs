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
    public class jobdescriptionsController : Controller
    {
        private JobreferenceEntities2 db = new JobreferenceEntities2();

        // GET: jobdescriptions
        public ActionResult Index()
        {
            return View(db.jobdescriptions.ToList());
        }

        // GET: jobdescriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobdescription jobdescription = db.jobdescriptions.Find(id);
            if (jobdescription == null)
            {
                return HttpNotFound();
            }
            return View(jobdescription);
        }

        // GET: jobdescriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jobdescriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "jobid,jobdescription1,requiredexp,noticeperiod,primaryskills,additional_skills,joblocation,salary")] jobdescription jobdescription)
        {
            if (ModelState.IsValid)
            {
                db.jobdescriptions.Add(jobdescription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobdescription);
        }

        // GET: jobdescriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobdescription jobdescription = db.jobdescriptions.Find(id);
            if (jobdescription == null)
            {
                return HttpNotFound();
            }
            return View(jobdescription);
        }

        // POST: jobdescriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "jobid,jobdescription1,requiredexp,noticeperiod,primaryskills,additional_skills,joblocation,salary")] jobdescription jobdescription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobdescription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobdescription);
        }

        // GET: jobdescriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobdescription jobdescription = db.jobdescriptions.Find(id);
            if (jobdescription == null)
            {
                return HttpNotFound();
            }
            return View(jobdescription);
        }

        // POST: jobdescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            jobdescription jobdescription = db.jobdescriptions.Find(id);
            db.jobdescriptions.Remove(jobdescription);
            db.SaveChanges();
            return RedirectToAction("Index");
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
