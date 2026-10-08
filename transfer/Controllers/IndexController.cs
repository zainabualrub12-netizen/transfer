using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using transfer.Models;

namespace transfer.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ViewData["name"] = "Anas";
            ViewData["city"] = "Amman";
            return View();
        }
        public ActionResult Index1()
        {
            ViewBag.name = "Anas";
            ViewBag.city = "Amman";
            return View();
        }
        public ActionResult Index2()
        {
            Customer customer1 = new Customer();
            customer1.name = "Anas";
            customer1.age = 35;
            customer1.gender = "male";
            customer1.city = "Amman";
            return View(customer1);
        }
    }

}