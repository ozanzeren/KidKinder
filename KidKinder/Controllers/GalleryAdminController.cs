using KidKinder.context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class GalleryAdminController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult GalleryList()
        {
            var values = context.Galleries
                .Where(g => g.Status)
                .Take(6)               
                .ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddImage(Gallery p)
        {
            p.Status = true;
            context.Galleries.Add(p);
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        [HttpPost]
        public ActionResult ChangeStatus(int id)
        {
            var gallery = context.Galleries.Find(id);
            gallery.Status = !gallery.Status;
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }

        public ActionResult DeleteImage(int id)
        {
            var value = context.Galleries.Find(id);
            context.Galleries.Remove(value);
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        [HttpGet]
        public ActionResult UpdateImage(int id)
        {
            var value = context.Galleries.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateImage(Gallery p)
        {
            var value = context.Galleries.Find(p.GalleryId);
            value.ImageUrl = p.ImageUrl;
            value.Title = p.Title;
            value.Status = p.Status;
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
    }
}
