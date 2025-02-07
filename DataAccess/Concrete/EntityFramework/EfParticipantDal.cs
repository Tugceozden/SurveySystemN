using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
	public class EfParticipantDal : IParticipantDal
	{
		public Participant Add(Participant entity)
		{
			throw new NotImplementedException();
		}

		public  Participant Delete(Participant entity,bool isSoftDelete = true)
		{
			throw new NotImplementedException();
		}

		public Participant? Get(Func<Participant, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public IList<Participant> GetList(Func<Participant, bool>? predicate = null)
		{
			throw new NotImplementedException();
		}

		public Participant Update(Participant entity)
		{
			throw new NotImplementedException();
		}
	}
}
