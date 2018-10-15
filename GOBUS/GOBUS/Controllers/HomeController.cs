﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOBUS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.GOBUSContext dbCtx = new Models.GOBUSContext();
            new Models.GOBUSDbInitializer().InitializeDatabase(dbCtx);
            return View();
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