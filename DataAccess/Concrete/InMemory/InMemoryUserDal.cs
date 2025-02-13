using Core.DataAccess.InMemory;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace DataAccess.Concrete.InMemory
{
	public class InMemoryUserDal :InMemoryEntityRepositoryBase<User,int>, IUserDal
	{

		protected override int generateId()
		{
			int nextId = Entities.Count == 0 ? 1 : Entities.Max(e => e.Id) + 1;
			return nextId;
		}

	}
}
