﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameManager.WebAPI.Controllers.GenreControllers
{
    public class GenreController : Controller
    {
        // GET: Genre
        public ActionResult Index()
        {
            return View();
        }
    }
}