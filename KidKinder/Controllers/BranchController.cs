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

    public class BranchController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult BranchList()
        {
            var values =context.Branches.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateBranch()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBranch(Branch p)
        {
            context.Branches.Add(p);
            context.SaveChanges();
            return RedirectToAction("BranchList");
        }
        public ActionResult DeleteBranch(int id)
        {
            var value = context.Branches.Find(id);
            context.Branches.Remove(value);
            context.SaveChanges();
            return RedirectToAction("BranchList");
        }
        [HttpGet]
        public ActionResult UpdateBranch (int id)
        {
            var value = context.Branches.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBranch(Branch p) 
        {
            var value = context.Branches.Find(p.BranchId);
            value.Name = p.Name;
            context.SaveChanges();
            return RedirectToAction("BranchList");
        }
    }
}