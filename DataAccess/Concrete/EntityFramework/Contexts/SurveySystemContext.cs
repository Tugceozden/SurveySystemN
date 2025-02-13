

using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
	public  class SurveySystemContext:DbContext
	{
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyResult> SurveyResults { get; set; }
        public DbSet<User> Users { get; set; }

        public SurveySystemContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
                
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Participant>()
				.HasOne(p => p.User)
				.WithMany() // Eğer User'ın birden fazla Participant kaydı olabilir diyorsan WithMany(p => p.Participants) kullan
				.HasForeignKey(p => p.UserID)
				.OnDelete(DeleteBehavior.Cascade); // User silinirse Participant kaydı da silinir

			base.OnModelCreating(modelBuilder);
		}


	}
}
