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
		private readonly HashSet<User> _users = new();

		public void Add(User entity)
		{
			_users.Add(entity);
		}

		public void Delete(User entity)
		{
			_users.Remove(entity);
		}

		public User? GetById(int id)
		{
			return _users.FirstOrDefault(u => u.Id == id);
		}

		public IList<User> GetList()
		{
			return _users.ToList();
		}

		public void Update(User entity)
		{
			var userToUpdate = _users.FirstOrDefault(u => u.Id == entity.Id);
			if (userToUpdate != null)
			{
				_users.Remove(userToUpdate);
				_users.Add(entity);  // Güncellenmiş haliyle tekrar ekle
			}
		}
	}
}
