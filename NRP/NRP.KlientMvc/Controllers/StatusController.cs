using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NRP.KlientMvc.Models;

namespace NRP.KlientMvc.Controllers
{
    [HandleError(ExceptionType = typeof(DBConcurrencyException), View = "Errors")]
    public class StatusController : Controller
    {
        private NrpEntities db = new NrpEntities();

        [OutputCache(VaryByParam ="Version", Duration = 300)]
        public ActionResult Index()
        {
            return View(db.Status.ToList());
        }

        public ActionResult Info()
        {
            return View();
        }

        [Authorize(Roles ="Users")]
        public ActionResult Details(int? id)
        {
            //if(User.IsInRole("Administrators")) return 

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Status status = db.Status.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        // GET: Status/Create
        [Authorize(Roles ="Users")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Status/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nazwa")] Status status)
        {
            if (ModelState.IsValid)
            {
                db.Status.Add(status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(status);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Status status = db.Status.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        // POST: Status/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nazwa")] Status status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(status);
        }

        // GET: Status/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Status status = db.Status.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        // POST: Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var statusy = db.Status.Where(s => s.Nazwa.StartsWith("A")).ToList();
            Status status = db.Status.Find(id);
            db.Status.Remove(status);
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
