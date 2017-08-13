using System.Web.Mvc;

namespace HorseRace
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}