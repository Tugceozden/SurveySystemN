


using AutoMapper;
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
		private readonly IMapper _mapper;	
		public ParticipantManager(IParticipantDal participantDal, ParticipantBusinessRules participantBusinessRules, IMapper mapper
			)
	{
			_participantDal = participantDal; //new InMemoryParticipantDal();	// başka katmanların class'ları new'lenmez . O yüzden dependency injection kullanıyoruz.
			_participantBusinessRules = participantBusinessRules;
			_mapper = mapper;
     }

		public AddParticipantResponse Add(AddParticipantRequest request)
		{
			_participantBusinessRules.CheckIfParticipantNameNotExists(request.Name);
			Participant participantToAdd = 
				_mapper.Map<Participant>(request);
			_participantDal.Add(participantToAdd);

			AddParticipantResponse response = _mapper.Map<AddParticipantResponse>(participantToAdd);	
			return response;
		}


		public GetParticipantListResponse GetList(GetParticipantListRequest request)
		{

			IList<Participant>participantList =_participantDal.GetList();

			GetParticipantListResponse response = _mapper.Map<GetParticipantListResponse>(participantList);	
			return response;


		}

		public GetParticipantListResponse GetList(GetParticipantListRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
