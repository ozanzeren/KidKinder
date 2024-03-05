using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.context;

namespace KidKinder.Controllers
{
    public class AboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }
    }
}