using Core.DataAccess;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemorySurveyDal : ISurveyDal
	{
		private readonly HashSet<Survey> _surveys = new();

		public void Add(Survey entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Survey entity)
		{
			throw new NotImplementedException();
		}

		public Survey? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<Survey> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(Survey entity)
		{
			throw new NotImplementedException();
		}
	}
}
