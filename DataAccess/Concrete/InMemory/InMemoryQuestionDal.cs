using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryQuestionDal : IQuestionDal
	{
		private readonly HashSet<Question> _questions = new();

		public void Add(Question entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Question entity)
		{
			throw new NotImplementedException();
		}

		public Question? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<Question> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(Question entity)
		{
			throw new NotImplementedException();
		}
	}
}
