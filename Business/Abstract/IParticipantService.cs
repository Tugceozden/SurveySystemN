

using Business.Requests.Paticipant;
using Entities.Concrete;

namespace Business.Abstract
{
	public  interface IParticipantService
	{

		public Participant Add(AddParticipantRequest request);

		public IList<Participant> GetList();	
	}
}
