using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoYourChores.Models;

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
            catBox.TimeToCleanAgain = DateTime.UtcNow.AddDays(1);
            _context.SaveChanges();
            return View(catBox);
        }

        public ActionResult Index()
        {
            var catBox = _context.CatBox.SingleOrDefault();
            return View(catBox);
        }
    }
}