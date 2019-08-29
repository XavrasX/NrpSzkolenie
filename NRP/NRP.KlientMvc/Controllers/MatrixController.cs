using NRP.KlientMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NRP.KlientMvc.Controllers
{
    public class MatrixController : Controller
    {
        // GET: Matrix
        public ActionResult Index()
        {
            var model = new Matrix();
            return View(model);
        }
    }
}