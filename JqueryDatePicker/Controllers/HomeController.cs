using JqueryDatePicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryDatePicker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Customer cust = new Customer();
            cust.JoinDate = DateTime.Now.ToShortDateString();
            return View(cust);
        }

        [HttpPost]
        public ActionResult Index(Customer cust)
        {
            string joinDate = cust.JoinDate;

            ViewBag._firstDate = cust.JoinDate;
            

            return View();

        }
    }
}