using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyNaggingMom.Models;

namespace MyNaggingMom.Controllers
{
    public class CatBoxController : Controller
    {
        private CatBox catBox = new CatBox();
        
        public ActionResult Clean(CatBox catBox)
        {
            return View(catBox);
        }
    }
}