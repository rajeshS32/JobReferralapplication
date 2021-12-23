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
    public class referenceregsController : Controller
    {
        private JobreferenceEntities2 db = new JobreferenceEntities2();

        // GET: referenceregs
        public ActionResult Index()
        {
            return View(db.referenceregs.ToList());
        }

        // GET: referenceregs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referencereg referencereg = db.referenceregs.Find(id);
            if (referencereg == null)
            {
                return HttpNotFound();
            }
            return View(referencereg);
        }

        // GET: referenceregs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: referenceregs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userid,username,password,mobile,email,address,state,country")] referencereg referencereg)
        {
            if (ModelState.IsValid)
            {
                db.referenceregs.Add(referencereg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referencereg);
        }

        // GET: referenceregs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referencereg referencereg = db.referenceregs.Find(id);
            if (referencereg == null)
            {
                return HttpNotFound();
            }
            return View(referencereg);
        }

        // POST: referenceregs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userid,username,password,mobile,email,address,state,country")] referencereg referencereg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referencereg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referencereg);
        }

        // GET: referenceregs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            referencereg referencereg = db.referenceregs.Find(id);
            if (referencereg == null)
            {
                return HttpNotFound();
            }
            return View(referencereg);
        }

        // POST: referenceregs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            referencereg referencereg = db.referenceregs.Find(id);
            db.referenceregs.Remove(referencereg);
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
