

using Entities.Concrete;

namespace Business.Abstract
{
	public  interface IParticipantService
	{

		public Participant Add(Participant participant);

		public IList<Participant> GetList();	
	}
}
