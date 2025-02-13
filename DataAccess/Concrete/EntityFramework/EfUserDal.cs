

using Core.DataAccess.EntityFramwork;
using Core.Entities;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User, int, SurveySystemContext>, IUserDal
	{
		public EfUserDal(SurveySystemContext context) : base(context)
		{
		}
	}
}
