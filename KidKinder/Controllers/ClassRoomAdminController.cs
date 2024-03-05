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
    public class ClassRoomAdminController : Controller
    {

        KidKinderContext context = new KidKinderContext();
        public ActionResult ClassRoomList()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateClassRoom()
        {
            List<SelectListItem> values = (from x in context.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.BranchId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateClassRoom(ClassRoom p)
        {
            context.ClassRooms.Add(p);
            context.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }

        public ActionResult DeleteClassRoom(int id)
        {
            var value = context.ClassRooms.Find(id);
            context.ClassRooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }
        [HttpGet]
        public ActionResult UpdateClassRoom(int id)
        {
            List<SelectListItem> values = (from x in context.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.BranchId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.ClassRooms.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateClassRoom(ClassRoom p)
        {
            var value = context.ClassRooms.Find(p.ClassRoomId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.AgeOfKids = p.AgeOfKids;
            value.TotalSeats = p.TotalSeats;
            value.ClassTime = p.ClassTime;
            value.Price = p.Price;
            value.ImageUrl = p.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }
    }

}
