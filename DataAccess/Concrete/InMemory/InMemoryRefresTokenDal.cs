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
	public class InMemoryRefresTokenDal : InMemoryEntityRepositoryBase<RefreshToken, int>, IRefreshTokenDal
	{
		public void Add(IRefreshTokenDal entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(IRefreshTokenDal entity)
		{
			throw new NotImplementedException();
		}

		public void Update(IRefreshTokenDal entity)
		{
			throw new NotImplementedException();
		}

		IRefreshTokenDal? IEntityRepository<IRefreshTokenDal, int>.GetById(int id)
		{
			throw new NotImplementedException();
		}

		IList<IRefreshTokenDal> IEntityRepository<IRefreshTokenDal, int>.GetList()
		{
			throw new NotImplementedException();
		}
	}
}
