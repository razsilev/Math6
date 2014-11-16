using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMathApp.Web.Areas.Ideas.Controllers
{
    public class IdeaController : Controller
    {
        // GET: Ideas/Idea
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult CreateIdea(string idea)
        {
            if (ModelState.IsValid)
            {
                // save to db
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}