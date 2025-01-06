using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ParticipantsController : ControllerBase
	{
		private readonly IParticipantService _participantService;

		public ParticipantsController()
		{
			_participantService = ServiceRegistration.ParticipantService;
		}	



		[HttpGet] //GET http://localhost:5161/api/participants
		public ICollection<Participant> Getlist() 
		{
			IList<Participant>participantList = _participantService.GetList();
			return participantList;
		}
		[HttpPost] //POST http://localhost:5161/api/participants
		public Participant Add(Participant addParticipantRequest) 
		{
			Participant addParticipant =_participantService.Add(addParticipantRequest);
		    return addParticipant;
		}





	}
}
