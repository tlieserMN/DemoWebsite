﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebsite.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Account()
        {
            return View("Account", TEMPDATA.LOGEDINUSER);
        }
    }
}