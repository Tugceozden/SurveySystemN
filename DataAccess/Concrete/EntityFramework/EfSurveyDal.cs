

using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfSurveyDal : EfEntityRepositoryBase<Survey, int, SurveySystemContext>, ISurveyDal
	{
		public EfSurveyDal(SurveySystemContext context) : base(context)
		{
		}
	}
}
