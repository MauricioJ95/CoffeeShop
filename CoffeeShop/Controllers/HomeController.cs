﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ConfMessage = "Thanks " + newUser.FirstName;

                return View("Confirm");
            }
            else
            {
                return View("Error");
            }
        }
    }
}