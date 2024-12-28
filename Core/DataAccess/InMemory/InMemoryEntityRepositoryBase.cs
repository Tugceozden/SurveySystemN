﻿using Core.Entities;
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
			entity.CreatedAt = DateTime.Now;	
			_entities.Add(entity);	
		}

		public void Delete(TEntity entity)
		{
			entity.DeletedAt = DateTime.Now;
			_entities.Remove(entity);	

		}

		public TEntity? GetById(TEntityId id)
		{
         TEntity? entity=_entities.FirstOrDefault(e =>e.Id.Equals(id)&& e.DeletedAt.HasValue ==false);
			return entity;
		}

		public IList<TEntity> GetList()
		{
			IList<TEntity> entities = _entities
		  .Where(e => e.DeletedAt.HasValue == false)
			.ToList();
			return entities;	
		}
		
		public void Update(TEntity entity)
		{
			entity.UpdateAt = DateTime.UtcNow;		}

		
	}
}
