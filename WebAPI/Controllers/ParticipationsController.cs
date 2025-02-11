using Business;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ParticipationsController : ControllerBase
	{
		private readonly IParticipationService _participationService;
		private GetParticipantListResponse response;

		public ParticipationsController(IParticipationService participationService)
        {
           _participationService = participationService;

        }
		[HttpGet]
		public GetParticipantListResponse GetList(GetParticipantListRequest request) 
		{
			GetParticipantListResponse getParticipantListResponse = _participationService.GetList(request);
			return response;	
		
		
		}



    }
}
