using KidKinder.context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class FeatureController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult FeatureList()
        {
            var values = context.Features.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(Feature p)
        {
            var value = context.Features.Find(p.FeatureId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.Header = p.Header;
            value.ImageUrl = p.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}