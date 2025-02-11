

using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfSurveyResultDal : ISurveyResultDal
	{
		private readonly SurveySystemContext _context;
        public EfSurveyResultDal(SurveySystemContext context)
        {
			_context = context;	
        }
        public SurveyResult Add(SurveyResult entity)
		{
			entity.CreatedAt = DateTime.UtcNow;
			_context.SurveyResults.Add(entity);
			_context.SaveChanges();
			return entity;
		}

		public SurveyResult Delete(SurveyResult entity, bool isSoftDelete = true)
		{
			entity.DeletedAt = DateTime.UtcNow;
			if (!isSoftDelete)

				_context.SurveyResults.Remove(entity);
			_context.SaveChanges();
			return entity;
		}

		public SurveyResult? Get(Func<SurveyResult, bool> predicate)
		{
			SurveyResult? surveyResult = _context.SurveyResults.FirstOrDefault(predicate);
			return surveyResult;
		}

		public IList<SurveyResult> GetList(Func<SurveyResult, bool>? predicate = null)
		{
			IQueryable<SurveyResult> query = _context.Set<SurveyResult>();
			if (predicate != null)
				query = query.Where(predicate).AsQueryable();
			return query.ToList();
		}

		public SurveyResult Update(SurveyResult entity)
		{
			entity.UpdateAt = DateTime.UtcNow;
			_context.SurveyResults.Update(entity);
			_context.SaveChanges();
			return entity;
		}
	}
}
