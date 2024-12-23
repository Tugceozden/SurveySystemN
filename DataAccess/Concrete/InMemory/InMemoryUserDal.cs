using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryUserDal : IUserDal
	{
		private readonly HashSet<User>_users;
		public void Add(IUserDal entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(IUserDal entity)
		{
			throw new NotImplementedException();
		}

		public IUserDal GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<IUserDal> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(IUserDal entity)
		{
			throw new NotImplementedException();
		}
	}
}
