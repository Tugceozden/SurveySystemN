using Business.Dtos.Participant;
using Entities.Concrete;

namespace Business
{
	public class GetParticipantListResponse
	{
		public ICollection<ParticipantListItemDto> Items { get; set; }	


	}
}