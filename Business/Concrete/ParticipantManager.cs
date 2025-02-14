


using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Participant;
using Business.Responses.Participant;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
	public class ParticipantManager : IParticipantService
	{
		private readonly IParticipantDal _participantDal;
		private readonly ParticipantBusinessRules _participantBusinessRules;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;
		public ParticipantManager(IParticipantDal participantDal, ParticipantBusinessRules participantBusinessRules,
			IMapper mapper, IHttpContextAccessor httpContextAccessor
			)
	{
			_participantDal = participantDal; //new InMemoryParticipantDal();	// başka katmanların class'ları new'lenmez . O yüzden dependency injection kullanıyoruz.
			_participantBusinessRules = participantBusinessRules;
			_mapper = mapper;
			_httpContextAccessor = httpContextAccessor;
     }

		public AddParticipantResponse Add(AddParticipantRequest request)
		{
			if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
			{
				throw new Exception("Bu endpointi uygulamak için giriş yapmak durumundasınız.");
			}
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

		
	}
}
