

using Business.Requests.Participant;
using Business.Responses.Participant;
using Entities.Concrete;

namespace Business.Abstract
{
	public  interface IParticipantService
	{

		public AddParticipantResponse Add(AddParticipantRequest request);

		public GetParticipantListResponse GetList(GetParticipantListRequest request);	
	}
}
