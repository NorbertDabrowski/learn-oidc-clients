﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithOIDCtoAAD.Controllers {
  public class HomeController : Controller {
    public ActionResult Index() {

      string name1 = HttpContext.User.Identity.Name;
      string name2 = User.Identity.Name;


      return View();
    }

    public ActionResult About() {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact() {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}