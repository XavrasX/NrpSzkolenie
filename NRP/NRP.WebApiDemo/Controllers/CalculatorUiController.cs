using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NRP.WebApiDemo.Controllers
{
    public class CalculatorUiController : Controller
    {
        // GET: CalculatorUi
        public ActionResult Index()
        {
            return View();
        }
    }
}