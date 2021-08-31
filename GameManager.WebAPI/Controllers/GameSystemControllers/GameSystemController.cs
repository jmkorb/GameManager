using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameManager.WebAPI.Controllers.GameSystemControllers
{
    public class GameSystemController : Controller
    {
        // GET: GameSystem
        public ActionResult Index()
        {
            return View();
        }
    }
}