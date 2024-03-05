using KidKinder.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class TeacherUIController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var value = context.Teachers.ToList();
            return View(value);
        }
        public PartialViewResult TeacherHeaderPartial()
        {
            return PartialView();
        }
             
    }
}