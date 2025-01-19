


using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Participant;
using Business.Responses.Participant;
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

		public AddParticipantResponse Add(AddParticipantRequest request)
		{
			_participantBusinessRules.CheckIfParticipantNameNotExists(request.Name);
			Participant participantToAdd= new (request.Name,request.Surname,request.Email);	
			_participantDal.Add(participantToAdd);

			AddParticipantResponse response = new(participantToAdd.Id,participantToAdd.Surname,participantToAdd.Name,participantToAdd.Email);
			return response;
		}


		public IList<Participant> GetList()
		{

			IList<Participant>participantList =_participantDal.GetList();
			return participantList;


		}
	}
}
