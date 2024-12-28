using Core.DataAccess;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryRefreshTokenDal : IRefreshTokenDal
	{
		private readonly HashSet<RefreshToken> _refreshToken = new();

		public void Add(RefreshToken entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(RefreshToken entity)
		{
			throw new NotImplementedException();
		}

		public RefreshToken? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<RefreshToken> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(RefreshToken entity)
		{
			throw new NotImplementedException();
		}
	}
}
