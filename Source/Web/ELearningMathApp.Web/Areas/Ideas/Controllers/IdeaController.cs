using ELearningMathApp.Data.Common.Repository;
using ELearningMathApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

using AutoMapper.QueryableExtensions;
using ELearningMathApp.Web.Areas.Ideas.Models.Idea;

namespace ELearningMathApp.Web.Areas.Ideas.Controllers
{
    public class IdeaController : Controller
    {
        private IRepository<IdeaDbModel> ideasRepo;

        public IdeaController(IRepository<IdeaDbModel> ideasRepo)
        {
            this.ideasRepo = ideasRepo;
        }

        // GET: Ideas/Idea
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult CreateIdea(string idea)
        {
            if (idea != null && idea.Length > 50)
            {
                // save to db
                var newIdea = new IdeaDbModel()
                    {
                        AuthorId = this.User.Identity.GetUserId(),
                        Content = idea,
                        CreatedOn = DateTime.Now
                    };

                this.ideasRepo.Add(newIdea);
                this.ideasRepo.SaveChanges();

                return RedirectToAction("ShowIdeas");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ShowIdeas()
        {
            var ideas = this.ideasRepo
                .All()
                .OrderBy(i => i.CreatedOn)
                .Project()
                .To<IdeaViewModel>()
                .ToList();

            return View(ideas);
        }
    }
}