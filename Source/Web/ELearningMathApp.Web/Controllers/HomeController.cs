namespace ELearningMathApp.Web.Controllers
{
    using ELearningMathApp.Data.Common.Repository;
    using ELearningMathApp.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private IRepository<Comment> comments;

        public HomeController(IRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}