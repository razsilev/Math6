namespace ELearningMathApp.Web.Areas.Ideas.Models.Idea
{
    using System;
    using System.Collections.Generic;

    using ELearningMathApp.Data.Models;
    using ELearningMathApp.Web.Infrastructure.Mapping;

    public class IdeaViewModel : IMapFrom<IdeaDbModel>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        //public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public virtual ICollection<User> UsersPozitiveVote { get; set; }

        public virtual ICollection<User> UsersNegativeVote { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}