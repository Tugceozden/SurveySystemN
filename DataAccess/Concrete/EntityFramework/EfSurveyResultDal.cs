

using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfSurveyResultDal : EfEntityRepositoryBase<SurveyResult, int, SurveySystemContext>, ISurveyResultDal
	{
		public EfSurveyResultDal(SurveySystemContext context) : base(context)
		{
		}
	}
}
