using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}