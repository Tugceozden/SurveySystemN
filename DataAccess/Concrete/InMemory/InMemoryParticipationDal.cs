﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryParticipationDal : IParticipationDal
	{
		private readonly HashSet<Participation> _participations = new();

		public void Add(Participation entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Participation entity)
		{
			throw new NotImplementedException();
		}

		public Participation? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<Participation> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(Participation entity)
		{
			throw new NotImplementedException();
		}
	}
}
