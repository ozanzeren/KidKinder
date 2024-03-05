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

    public class ServiceController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service p)
        {
            context.Services.Add(p);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public ActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service p)
        {
            var value = context.Services.Find(p.ServiceId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.IconUrl = p.IconUrl;
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}