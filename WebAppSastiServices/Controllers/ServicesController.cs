﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSastiServices.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Service()
        {
            return View();
        }

        public ActionResult ServiceDetail()
        {
            return View();
        }
    }
}