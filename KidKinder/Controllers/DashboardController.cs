using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using KidKinder.context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
      KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {            
            ViewBag.CizimCount = context.Teachers.Where(x=>x.BranchId == context.Branches.Where(z=>z.Name =="Çizim").Select(y=> y.BranchId).FirstOrDefault()).Count();
            ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");
            return View();
        }
    }
}