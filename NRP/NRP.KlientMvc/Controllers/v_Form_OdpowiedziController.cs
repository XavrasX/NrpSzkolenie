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

        public ActionResult Index(string viewName = null)
        {
            if (viewName == null)
                return View(db.v_Form_Odpowiedzi.ToList());

            return View(viewName, db.v_Form_Odpowiedzi.ToList());
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
