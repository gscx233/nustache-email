﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nustache.Core;

namespace email.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new { name = "SB", language = "JAVA", sender = "Yo" };
            var str = Render.FileToString(Server.MapPath("~/Template/MailTemplate.html"), data);
            ViewBag.Wer = str;
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