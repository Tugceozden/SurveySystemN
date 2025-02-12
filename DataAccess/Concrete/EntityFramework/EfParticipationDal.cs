using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
	public class EfParticipationDal : EfEntityRepositoryBase<Participation, int, SurveySystemContext>, IParticipationDal
	{
		public EfParticipationDal(SurveySystemContext context) : base(context)
		{
		}
	}
}
