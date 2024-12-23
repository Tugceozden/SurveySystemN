using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.InMemory
{
	public class InMemoryEntityRepositoryBase<TEntity, TEntityId> : IEntityRepository<TEntity, TEntityId>
		where TEntity : class, IEntity<TEntityId>, new()

	{
		private readonly HashSet<TEntity> _entities = new();
		public void Add(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public TEntity GetById(TEntityId id)
		{
			throw new NotImplementedException();
		}

		public List<TEntity> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity entity)
		{
			throw new NotImplementedException();
		}

		IList<TEntity> IEntityRepository<TEntity, TEntityId>.GetList()
		{
			throw new NotImplementedException();
		}
	}
}
