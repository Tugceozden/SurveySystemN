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
	public class InMemorySurveyDal :InMemoryEntityRepositoryBase<Survey,int>, ISurveyDal
	{
		
	}
}
