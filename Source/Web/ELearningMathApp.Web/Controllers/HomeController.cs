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
        private IRepository<IdeaDbModel> ideasRepo;

        public HomeController(IRepository<IdeaDbModel> ideasRepo)
        {
            this.ideasRepo = ideasRepo;
        }

        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            //var comments = this.comments.All().Project().To<IndexCommentViewModel>();

            var newIdeas = this.ideasRepo
                .All()
                .OrderBy(i => i.CreatedOn)
                .Take(3)
                .Project()
                .To<IndexIdeasViewModel>()
                .ToList();

            return View(newIdeas);
        }

    }
}