using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace WebAPI
{
	public static class ServiceRegistration
	{
		public static IParticipantDal ParticipantDal = new InMemoryParticipantDal();
		public static ParticipantBusinessRules ParticipantBusinessRules = new ParticipantBusinessRules(ParticipantDal);
		public static IParticipantService ParticipantService = new ParticipantManager(ParticipantDal, ParticipantBusinessRules);


	}
}
