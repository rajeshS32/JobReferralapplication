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
    public class referredjobsController : Controller
    {
        private JobreferenceEntities2 db = new JobreferenceEntities2();

        // GET: referredjobs
        public ActionResult Index()
        {
            return View(db.referredjobs.ToList());
        }

        // GET: referredjobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referredjob referredjob = db.referredjobs.Find(id);
            if (referredjob == null)
            {
                return HttpNotFound();
            }
            return View(referredjob);
        }

        // GET: referredjobs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: referredjobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "jobrefernceid,referredto,jobid,referredon,status,comments")] referredjob referredjob)
        {
            if (ModelState.IsValid)
            {
                db.referredjobs.Add(referredjob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referredjob);
        }

        // GET: referredjobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referredjob referredjob = db.referredjobs.Find(id);
            if (referredjob == null)
            {
                return HttpNotFound();
            }
            return View(referredjob);
        }

        // POST: referredjobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "jobrefernceid,referredto,jobid,referredon,status,comments")] referredjob referredjob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredjob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referredjob);
        }

        // GET: referredjobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referredjob referredjob = db.referredjobs.Find(id);
            if (referredjob == null)
            {
                return HttpNotFound();
            }
            return View(referredjob);
        }

        // POST: referredjobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            referredjob referredjob = db.referredjobs.Find(id);
            db.referredjobs.Remove(referredjob);
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
