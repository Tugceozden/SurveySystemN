


using Business.Abstract;
using Business.BusinessRules;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ParticipantManager : IParticipantService
	{
		private readonly IParticipantDal _participantDal;
		private readonly ParticipantBusinessRules _participantBusinessRules;

		public ParticipantManager(IParticipantDal participantDal, ParticipantBusinessRules participantBusinessRules)
	{
			_participantDal = participantDal; //new InMemoryParticipantDal();	// başka katmanların class'ları new'lenmez . O yüzden dependency injection kullanıyoruz.
     }

		public Participant Add(Participant participant)
		{
			_participantBusinessRules.CheckIfParticipantNameNotExists(participant.Name);
			
			_participantDal.Add(participant);
			return participant;
		}


		public IList<Participant> GetList()
		{

			IList<Participant>participantList =_participantDal.GetList();
			return participantList;


		}
	}
}
