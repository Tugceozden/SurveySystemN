using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryUserDal :IUserDal
	{
		private readonly HashSet<User> _users = new();

		public void Add(User entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(User entity)
		{
			throw new NotImplementedException();
		}

		public User? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<User> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(User entity)
		{
			throw new NotImplementedException();
		}
	}
}
