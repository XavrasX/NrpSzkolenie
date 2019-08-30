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
        private DAS.IOdpowiedziRepository _repo;

        public OdpowiedziController()
        {
            _repo = new DAS.OdpowiedziRepository();
        }

        public OdpowiedziController(DAS.IOdpowiedziRepository repository)
        {
            _repo = repository;
        }

        public ActionResult Index(string viewName = null)
        {
            if (viewName == null)
                return View(_repo.GetOdpowiedzi());

            return View(viewName, _repo.GetOdpowiedzi());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection forms)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateOdpowiedzi(null);
                var length = forms.Count - 1;
                for (int i = 0; i < length; i++)
                {
                    Response.Write($"<h2>{forms.AllKeys[i]}</h2><h3>{forms[i]}</h3>");
                }
                //return RedirectToAction("Index");
            }
            return View(_repo.GetOdpowiedzi(1));
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
