using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.context;

namespace KidKinder.Controllers
{
    public class LayoutController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult _Layout()
        {
            return View();
        }
        public PartialViewResult _NavBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }

        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }
    }
}