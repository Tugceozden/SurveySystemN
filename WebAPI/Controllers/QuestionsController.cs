using Business;
using Business.Abstract;
using Business.Requests.Question;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using static System.Net.WebRequestMethods;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QuestionsController : ControllerBase
	{
		private readonly IQuestionService _questionService;
        public QuestionsController(	IQuestionService questionService)
        {
			_questionService = questionService;	
        }

		[HttpGet] //Get    http://localhost:5245/api/questions
		public GetQuestionListResponse GetList( [FromQuery]GetQuestionListRequest request)
		{
			GetQuestionListResponse response = _questionService.GetList(request);
			return response;	

		}
		[HttpGet("{Id}")]//Get    http://localhost:5245/api/questions/1

		public GetQuestionByIdResponse GetById([FromRoute]GetQuestionByIdRequest request)
		{
			GetQuestionByIdResponse response=_questionService.GetById(request);
			return response;	

		}





		[HttpPost]  //Post   http://localhost:5245/api/questions
		public ActionResult<AddQuestionResponse> Add(AddQuestionRequest request)
		{ 
			AddQuestionResponse response = _questionService.Add(request);	
			return CreatedAtAction(
				actionName: nameof(GetById),
				routeValues: new {Id= response.Id },
				value:response
				);	

		}
		[HttpPut("Id")] //put http://localhost:5245/api/questions/1
		public ActionResult<UpdateQuestionResponse> Update([FromRoute]int Id,[FromBody]UpdateQuestionRequest request) 
		{
			if (Id != request.Id)
			{
				return BadRequest();	

			}	

			UpdateQuestionResponse response = _questionService.Update(request);	
			return Ok(response);
		
		}
		[HttpDelete("Id")]
		public DeleteQuestionResponse Delete([FromRoute] DeleteQuestionRequest request)
		{
		
		DeleteQuestionResponse response = _questionService.Delete(request);
			return response;
		
		}


	}
}
