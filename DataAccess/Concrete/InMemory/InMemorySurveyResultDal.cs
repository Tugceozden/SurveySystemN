﻿using Core.DataAccess;
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
	public class InMemorySurveyResultDal : ISurveyResultDal
	{

		private readonly HashSet<SurveyResult> _surveyResults = new();

		public void Add(SurveyResult entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(SurveyResult entity)
		{
			throw new NotImplementedException();
		}

		public SurveyResult? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<SurveyResult> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(SurveyResult entity)
		{
			throw new NotImplementedException();
		}
	}
}
	
		