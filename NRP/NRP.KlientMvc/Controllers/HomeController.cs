using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NRP.KlientMvc.Controllers
{
    public class HomeController : Controller
    {
        public void NeverDoLikeThis(string nr)
        {
            var i = 0;
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
            Response.Write($"<h1>Hello from Home controller</h1>{nr} {++i}<h2>OnlyControllerDemo action invoked</h2>");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}