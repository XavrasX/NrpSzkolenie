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
    public class OdpowiedziController : Controller
    {
        private NrpOdpowiedziEntities db = new NrpOdpowiedziEntities();

        // GET: v_Form_Odpowiedzi
        public ActionResult Index()
        {
            return View(db.v_Form_Odpowiedzi.ToList());
        }

        // GET: v_Form_Odpowiedzi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            v_Form_Odpowiedzi v_Form_Odpowiedzi = db.v_Form_Odpowiedzi.Find(id);
            if (v_Form_Odpowiedzi == null)
            {
                return HttpNotFound();
            }
            return View(v_Form_Odpowiedzi);
        }

        // GET: v_Form_Odpowiedzi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: v_Form_Odpowiedzi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idOdpowiedzi,trescPytania,odpowiedz")] v_Form_Odpowiedzi v_Form_Odpowiedzi)
        {
            if (ModelState.IsValid)
            {
                db.v_Form_Odpowiedzi.Add(v_Form_Odpowiedzi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(v_Form_Odpowiedzi);
        }

        // GET: v_Form_Odpowiedzi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            v_Form_Odpowiedzi v_Form_Odpowiedzi = db.v_Form_Odpowiedzi.Find(id);
            if (v_Form_Odpowiedzi == null)
            {
                return HttpNotFound();
            }
            return View(v_Form_Odpowiedzi);
        }

        // POST: v_Form_Odpowiedzi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idOdpowiedzi,trescPytania,odpowiedz")] v_Form_Odpowiedzi v_Form_Odpowiedzi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(v_Form_Odpowiedzi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(v_Form_Odpowiedzi);
        }

        // GET: v_Form_Odpowiedzi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            v_Form_Odpowiedzi v_Form_Odpowiedzi = db.v_Form_Odpowiedzi.Find(id);
            if (v_Form_Odpowiedzi == null)
            {
                return HttpNotFound();
            }
            return View(v_Form_Odpowiedzi);
        }

        // POST: v_Form_Odpowiedzi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            v_Form_Odpowiedzi v_Form_Odpowiedzi = db.v_Form_Odpowiedzi.Find(id);
            db.v_Form_Odpowiedzi.Remove(v_Form_Odpowiedzi);
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
