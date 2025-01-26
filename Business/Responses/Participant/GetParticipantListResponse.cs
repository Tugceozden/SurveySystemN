using Business.Dtos.Participant;
using Entities.Concrete;

namespace Business
{
	public class GetParticipantListResponse
	{
		public ICollection<ParticipantListItemDto> Items { get; set; }	

		public GetParticipantListResponse() 
		{ 
		   Items= Array.Empty<ParticipantListItemDto>();	
		}	

		public GetParticipantListResponse(ICollection<ParticipantListItemDto> items)
		{

			Items= items;	
		}


	}
}