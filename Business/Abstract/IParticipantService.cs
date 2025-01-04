

using Entities.Concrete;

namespace Business.Abstract
{
	public  interface IParticipantService
	{

		public Participant AddParticipant(Participant participant);

		public IList<Participant> GetList();	
	}
}
