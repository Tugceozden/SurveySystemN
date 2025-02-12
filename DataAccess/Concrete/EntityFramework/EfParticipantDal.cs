using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace DataAccess.Concrete.EntityFramework
{

	public class EfParticipantDal : EfEntityRepositoryBase<Participant, int, SurveySystemContext>, IParticipantDal
	{
		public EfParticipantDal(SurveySystemContext context) : base(context)
		{
		}
	}
}
