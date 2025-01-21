

using AutoMapper;
using Business.Requests.Participant;
using Business.Responses.Participant;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
	public  class ParticipantMapperProfiles:Profile
	{
        public ParticipantMapperProfiles()
        {

            CreateMap<AddParticipantRequest, Participant>();
            CreateMap<Participant, AddParticipantResponse>();
            
        }

    }
}
