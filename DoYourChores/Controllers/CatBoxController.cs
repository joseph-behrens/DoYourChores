using DoYourChores.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DoYourChores.Controllers
{
    public class CatBoxController : Controller
    {
        private ApplicationDbContext _context;

        public CatBoxController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Clean()
        {
            var catBox = _context.CatBox.SingleOrDefault();
            catBox.LastTimeCleaned = DateTime.UtcNow;
            catBox.TimeToCleanAgain = DateTime.UtcNow.AddDays(2);
            _context.SaveChanges();
            catBox.Message = "Thank you for cleaning the catbox!";
            return View("../Home/Index", catBox);
        }

        public ActionResult Index()
        {
            var catBox = _context.CatBox.SingleOrDefault();
            return View(catBox);
        }
    }
}