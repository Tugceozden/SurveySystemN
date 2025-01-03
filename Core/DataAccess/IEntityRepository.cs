﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
	public  interface IEntityRepository<TEntity,TEntityId>
	{
		public IList<TEntity> GetList();
		public TEntity? GetById(TEntityId id);
		public void Add(TEntity entity);
		public void Delete(TEntity entity);
		public void Update(TEntity entity);
	}
}
