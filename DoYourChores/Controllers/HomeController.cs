using DoYourChores.Models;
using System.Linq;
using System.Web.Mvc;

namespace DoYourChores.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public ActionResult Index()
        {
            var catBox = _context.CatBox.SingleOrDefault();
            catBox.Message = "";
            return View(catBox);
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

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
    }
}