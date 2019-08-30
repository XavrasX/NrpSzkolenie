using System.Web.Mvc;

namespace NRP.KlientMvc.Controllers
{
    [RequireHttps]

    public class CalculatorUiController : Controller
    {
        //[ChildActionOnly]
        [RequireHttps]
        public ActionResult Index()
        {
            ViewBag.Cokolwiek = "Hello";
            return View();
        }
    }
}