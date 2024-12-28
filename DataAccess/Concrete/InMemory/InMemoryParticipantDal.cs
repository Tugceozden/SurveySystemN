using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryParticipantDal : IParticipantDal
	{
		private readonly HashSet<Participant> _participants = new();

		public void Add(Participant entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Participant entity)
		{
			throw new NotImplementedException();
		}

		public Participant? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<Participant> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(Participant entity)
		{
			throw new NotImplementedException();
		}
	}
}
