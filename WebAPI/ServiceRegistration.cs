using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace WebAPI
{
	public static class ServiceRegistration
	{
		public static IParticipantDal ParticipantDal = new InMemoryParticipantDal();
		public static IParticipantService ParticipantService = new ParticipantManager(ParticipantDal);


	}
}
