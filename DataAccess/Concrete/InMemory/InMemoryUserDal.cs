using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryUserDal :InMemoryEntityRepositoryBase<User,int>, IUserDal
	{
		

		
	}
}
