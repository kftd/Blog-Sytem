﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
    }
}