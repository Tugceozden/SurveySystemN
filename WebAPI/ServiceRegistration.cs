using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Participant;
using Business.Responses.Participant;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebAPI
{
	public static class ServiceRegistration
	{
		public static IParticipantDal ParticipantDal = new InMemoryParticipantDal();
		public static ParticipantBusinessRules ParticipantBusinessRules = new ParticipantBusinessRules(ParticipantDal);
		public static IMapper Mapper => new MapperConfiguration(cfg =>
		{
			cfg.CreateMap<AddParticipantRequest, Participant>();
			cfg.CreateMap<Participant, AddParticipantResponse>();

		}).CreateMapper();


		public static IParticipantService ParticipantService = new ParticipantManager(ParticipantDal, ParticipantBusinessRules,Mapper);


	}
}
