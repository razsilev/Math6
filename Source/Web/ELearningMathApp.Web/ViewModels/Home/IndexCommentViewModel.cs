namespace ELearningMathApp.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using ELearningMathApp.Data.Models;
    using ELearningMathApp.Web.Infrastructure.Mapping;

    public class IndexCommentViewModel : IMapFrom<Comment>
    {
        public string Name { get; set; }
    }
}