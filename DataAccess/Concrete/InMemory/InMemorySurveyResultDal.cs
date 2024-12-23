using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemorySurveyResultDal : IEntityRepository<SurveyResult, int>
	{

		private readonly HashSet<SurveyResult> _surveyResults = new();
		public void Add(SurveyResult entity)
		{
			entity.CreatedAt = DateTime.Now;
			_surveyResults.Add(entity);	



		}

		public void Delete(SurveyResult entity)
		{
			entity.DeleteAt = DateTime.Now;

		}

		public SurveyResult GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<SurveyResult> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(SurveyResult entity)
		{
			throw new NotImplementedException();
		}
	}
}
	
		