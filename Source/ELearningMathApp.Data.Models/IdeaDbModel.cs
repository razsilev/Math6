namespace ELearningMathApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IdeaDbModel
    {
        public IdeaDbModel()
        {
            this.UsersPozitiveVote = new HashSet<User>();
            this.UsersNegativeVote = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(50)]
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public virtual ICollection<User> UsersPozitiveVote { get; set; }

        public virtual ICollection<User> UsersNegativeVote { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
