using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorials.Controllers
{
    public class MouseController : Controller
    {
        // GET: Mouse
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}