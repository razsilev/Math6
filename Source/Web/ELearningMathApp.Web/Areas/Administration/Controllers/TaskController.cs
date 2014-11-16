using ELearningMathApp.Web.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMathApp.Web.Areas.Administration.Controllers
{
    public class TaskController : Controller
    {
        // GET: Administration/Task
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskInputModel task)
        {
            if (this.ModelState.IsValid)
            {
                // redirect to all tasks
            }

            return View(task);
        }
    }
}