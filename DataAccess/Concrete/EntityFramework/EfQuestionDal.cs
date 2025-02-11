

using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfQuestionDal : IQuestionDal
	{
		private readonly SurveySystemContext _context;
        public EfQuestionDal(SurveySystemContext context)
        {
			_context = context;
        }
        public Question Add(Question entity)
		{
			entity.CreatedAt = DateTime.UtcNow;
			_context.Questions.Add(entity);
			_context.SaveChanges();
			return entity;


		}

		public Question Delete(Question entity, bool isSoftDelete = true)
		{
			entity.DeletedAt = DateTime.UtcNow;
			if (!isSoftDelete)

				_context.Questions.Remove(entity);
			_context.SaveChanges();
			return entity;


		}

		public Question? Get(Func<Question, bool> predicate)
		{
			Question? question = _context.Questions.FirstOrDefault(predicate);
			return question;
		}

		public IList<Question> GetList(Func<Question, bool>? predicate = null)
		{
			IQueryable<Question> query = _context.Set<Question>();
			if (predicate != null)
				query = query.Where(predicate).AsQueryable();
			return query.ToList();
		}

		public Question Update(Question entity)
		{
			entity.UpdateAt = DateTime.UtcNow;
			_context.Questions.Update(entity);
			_context.SaveChanges();
			return entity;
		}
	}
}
