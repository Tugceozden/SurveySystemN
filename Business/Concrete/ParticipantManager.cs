

using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ParticipantManager : IParticipantService
	{
		private IParticipantDal _participantDal;

		public ParticipantManager(IParticipantDal participantDal)
	{
			_participantDal = participantDal; //new InMemoryParticipantDal();	// başka katmanların class'ları new'lenmez . O yüzden dependency injection kullanıyoruz.
     }

		public Participant Add(Participant addparticipantRequest)
		{
			_participantDal.Add(addparticipantRequest);
			return addparticipantRequest;
		}


		public IList<Participant> GetList()
		{

			IList<Participant>participantList =_participantDal.GetList();
			return participantList;


		}
	}
}
