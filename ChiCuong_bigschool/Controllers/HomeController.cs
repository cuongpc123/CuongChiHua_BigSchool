﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity
using System.Web;
using System.Web.Mvc;

namespace ChiCuong_bigschool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext; 

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcomingCourse = _dbContext.Course
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DataTime > DataTime.Now);

            return View(upcomingCourse);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}