using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMathApp.Web.Controllers
{
    public class IdeasController : Controller
    {
        // GET: Ideas
        public ActionResult Index()
        {
            return View();
        }
    }
}