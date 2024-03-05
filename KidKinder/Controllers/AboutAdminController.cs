using KidKinder.context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    [Authorize]
    public class AboutAdminController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            var value = context.Abouts.Find(p.AboutId);
            value.Title = p.Title;
            value.BigImageUrl = p.BigImageUrl;
            value.Description = p.Description;
            value.SmallImageUrl = p.SmallImageUrl;
            value.Header= p.Header;
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}