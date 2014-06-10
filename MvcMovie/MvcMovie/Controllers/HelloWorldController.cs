﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorld/Welcome/

        public ActionResult Welcome(string nome, int numTimes = 1) 
        {
            ViewBag.Message = "Hello " + nome;
            ViewBag.NumTimes = numTimes;

            return View();
        }
	}
}