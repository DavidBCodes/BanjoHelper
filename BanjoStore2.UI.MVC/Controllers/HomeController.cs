using System.Web.Mvc;

namespace BanjoStore2.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Chords()
        {
            ViewBag.Message = "Chords";

            return View();
        }

        [HttpGet]
        public ActionResult Favorites()
        {
            ViewBag.Message = "Favorites";

            return View();
        }

        [HttpGet]
        public ActionResult BeginnerAdvice()
        {
            ViewBag.Message = "Beginner Advice";

            return View();
        }
    }
}
