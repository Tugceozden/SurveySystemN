

using AutoMapper;
using Business.Dtos.Participant;
using Business.Requests.Participant;
using Business.Responses.Participant;
using Entities.Concrete;
using System.Xml.Serialization;

namespace Business.Profiles.Mapping.AutoMapper
{
	public  class ParticipantMapperProfiles:Profile
	{
        public ParticipantMapperProfiles()
        {

            CreateMap<AddParticipantRequest, Participant>();
            CreateMap<Participant, AddParticipantResponse>();

            CreateMap<Participant, ParticipantListItemDto>();
            CreateMap<IList<Participant>, GetParticipantListResponse>()
            .ForMember(destinationMember: dest => dest.Items,
            memberOptions: opt => opt.MapFrom(mapExpression :src => src));

        }

    }
}
