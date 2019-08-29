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
        private DAS.IOdpowiedziRepository _repo = new DAS.OdpowiedziRepository();
        public ActionResult Index(string viewName = null)
        {
            if (viewName == null)
                return View(_repo.GetOdpowiedzi());

            return View(viewName, _repo.GetOdpowiedzi());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(List<v_Form_Odpowiedzi> listaOdpowiedzi)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateOdpowiedzi(listaOdpowiedzi);
                return RedirectToAction("Index");
            }
            return View(listaOdpowiedzi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
