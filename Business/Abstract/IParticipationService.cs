

using Business.Requests.Participant;
using Business.Requests.Participation;
using Business.Responses.Participant;
using Business.Responses.Participation;

namespace Business.Abstract
{
	public  interface IParticipationService
	{
		public AddParticipationResponse Add(AddParticipationRequest request);

		public GetParticipantListResponse GetList(GetParticipantListRequest request);
	}
}
