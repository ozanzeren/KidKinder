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

    public class StudentController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult StudentList()
        {
            var values = context.Students.ToList();
            return View(values);
        }
        public ActionResult ParentList()
        {
            var values = context.Students.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student p)
        {
            context.Students.Add(p);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }

        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var value = context.Students.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student p)
        {
            var value = context.Students.Find(p.StudentId);
            value.NameSurname= p.NameSurname;
            value.ImageUrl = p.ImageUrl;
            value.Address = p.Address;
            value.Phone = p.Phone;
            value.Veli1 = p.Veli1;
            value.Veli2 = p.Veli2;
            value.Veli3 = p.Veli3;
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
    }
}