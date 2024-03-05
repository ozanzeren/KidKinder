﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.context;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {
KidKinderContext context = new KidKinderContext();
            public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialFeature()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAboutList()
        {
            var values = context.AboutLists.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialClassRooms()
        {
            var values=context.ClassRooms.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookASeat()
        {
            return PartialView();
        }
        //Empty
        public PartialViewResult PartialTeacher()
        {

            var values = context.Teachers.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values =context.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAddress()
        {
            var values = context.Addresses.ToList();
            return PartialView(values);
        }
    }
}