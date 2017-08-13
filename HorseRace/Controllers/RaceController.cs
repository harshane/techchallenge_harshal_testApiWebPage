using HorseRace.ServiceProxy.Race;
using System.Web.Mvc;

namespace HorseRace.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRaceService _raceServiceProxy;

        public RaceController(IRaceService raceService)
        {
            _raceServiceProxy = raceService;
        }

        // GET: api/races
        public ActionResult Get()
        {
            return Json(_raceServiceProxy.GetTodaysRaces(), JsonRequestBehavior.AllowGet);
        }
    }
}
