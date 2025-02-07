

using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfQuestionDal : IQuestionDal
	{
		public Question Add(Question entity)
		{
			throw new NotImplementedException();
		}

		public Question Delete(Question entity, bool isSoftDelete = true)
		{
			throw new NotImplementedException();
		}

		public Question? Get(Func<Question, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public IList<Question> GetList(Func<Question, bool>? predicate = null)
		{
			throw new NotImplementedException();
		}

		public Question Update(Question entity)
		{
			throw new NotImplementedException();
		}
	}
}
