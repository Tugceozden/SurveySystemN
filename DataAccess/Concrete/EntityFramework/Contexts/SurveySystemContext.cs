

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
	public  class SurveySystemContext:DbContext
	{
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyResult> SurveyResults { get; set; }
        public DbSet<User> Users { get; set; }

        public SurveySystemContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
                
        }


    }
}
