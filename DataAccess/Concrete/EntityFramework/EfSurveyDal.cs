

using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfSurveyDal : ISurveyDal
	{
		private readonly SurveySystemContext _context;
        public EfSurveyDal(SurveySystemContext context)
        {
				_context = context;
        }
        public Survey Add(Survey entity)
		{
			entity.CreatedAt = DateTime.UtcNow;
			_context.Surveys.Add(entity);
			_context.SaveChanges();
			return entity;
		}

		public Survey Delete(Survey entity, bool isSoftDelete = true)
		{
			entity.DeletedAt = DateTime.UtcNow;
			if (!isSoftDelete)

				_context.Surveys.Remove(entity);
			_context.SaveChanges();
			return entity;
		}

		public Survey? Get(Func<Survey, bool> predicate)
		{
			Survey? survey = _context.Surveys.FirstOrDefault(predicate);
			return survey;
		}

		public IList<Survey> GetList(Func<Survey, bool>? predicate = null)
		{
			IQueryable<Survey> query = _context.Set<Survey>();
			if (predicate != null)
				query = query.Where(predicate).AsQueryable();
			return query.ToList();
		}

		public Survey Update(Survey entity)
		{
			entity.UpdateAt = DateTime.UtcNow;
			_context.Surveys.Update(entity);
			_context.SaveChanges();
			return entity;
		}
	}
}
