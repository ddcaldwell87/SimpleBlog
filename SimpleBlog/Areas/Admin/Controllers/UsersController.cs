﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")] // Allows access to this controller only if  user role is admin.
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return Content("USERS!!!");
        }
    }
}