

using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfQuestionDal : EfEntityRepositoryBase<Question, int, SurveySystemContext>, IQuestionDal
	{
		public EfQuestionDal(SurveySystemContext context) : base(context)
		{
		}
	}
}
