using System.Web.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "Your application history page.";
            return View();
        }

        public ActionResult CheckLink()
        {
            ViewBag.Message = "Your application about page.";
            return View();
        }
    }
}