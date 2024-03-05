using KidKinder.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ClassRoomUIController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
        }
        public PartialViewResult ClassRoomHeaderPartial()
        {
            return PartialView();
        }
    }

}