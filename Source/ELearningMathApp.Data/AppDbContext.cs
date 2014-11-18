namespace ELearningMathApp.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    
    using ELearningMathApp.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ELearningMathApp.Data.Migrations;
    using ELearningMathApp.Data.Common.Models;

    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        // Math6 db models collections
        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<IdeaDbModel> Ideas { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();

            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
