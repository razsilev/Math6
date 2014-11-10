namespace ELearningMathApp.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;

    using ELearningMathApp.Data.Common.Repository;
    using ELearningMathApp.Data.Models;
    using ELearningMathApp.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private IRepository<Comment> comments;

        public HomeController(IRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public ActionResult Index()
        {
            var comments = this.comments.All().Project().To<IndexCommentViewModel>();

            return View(comments);
        }

    }
}