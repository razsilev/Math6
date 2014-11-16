using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ELearningMathApp.Web.Areas.Administration.Models;
using ELearningMathApp.Web.Infrastructure;

namespace ELearningMathApp.Web.Areas.Administration.Controllers
{
    public class TaskController : Controller
    {
        private ISanitizer sanitizer;

        public TaskController(ISanitizer sanitizer)
        {
            this.sanitizer = sanitizer;
        }

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
                var sanitisedTask = this.sanitizer.Sanitize(task.Condition);
            }

            return View(task);
        }
    }
}