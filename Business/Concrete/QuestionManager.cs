

using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Dtos.Question;
using Business.Requests.Question;
using DataAccess.Abstract;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Business.Concrete
{
	public class QuestionManager : IQuestionService
	{
		private readonly IQuestionDal _questionDal; // veri yönetimi için eklendi
		private readonly QuestionBusinessRules _questionBusinessRules;  // iş kurallarını uygulamak için eklendi

		private readonly IMapper _mapper;   //mapping işlmeleri için eklendi

		public QuestionManager(IQuestionDal questionDal, QuestionBusinessRules questionBusinessRules, IMapper mapper)
		{
			_questionDal = questionDal;
			_questionBusinessRules = questionBusinessRules;
			_mapper = mapper;
		}

		public AddQuestionResponse Add(AddQuestionRequest request)
		{
			_questionBusinessRules.ValidateQuestionText(request.QuestionText);

			var questionToAdd = _mapper.Map<Question>(request);
			Question updatedQuestion= _questionDal.Add(questionToAdd);


			var response =  _mapper.Map<AddQuestionResponse>(updatedQuestion);
			return response;	
		}

		public DeleteQuestionResponse Delete(DeleteQuestionRequest request)
		{

			Question?  questionToDelete = _questionDal.Get(predicate: question => question.Id == request.Id);
			_questionBusinessRules.CheckIfQuestionExists(questionToDelete);

			Question deletedQuestion =_questionDal.Delete(questionToDelete);	

			
			 Question deleteQuestion= _questionDal.Delete(questionToDelete!);
			
			


			var response =_mapper.Map<DeleteQuestionResponse>(deletedQuestion);
			return response;	
		}

		public GetQuestionByIdResponse GetById(GetQuestionByIdRequest request)
		{

			Question? question = _questionDal.Get(predicate:question => question.Id == request.Id);	
			_questionBusinessRules.CheckIfQuestionExists(question);
			var response=_mapper.Map<GetQuestionByIdResponse>(question);	
			return response;	



		}

		public GetQuestionListResponse GetList(GetQuestionListRequest request)
		{
			IList<Question> questionList = _questionDal.GetList(question =>
	   request.FilterBySurveyId == null || question.SurveyId == request.FilterBySurveyId

   );
			var response = _mapper.Map<GetQuestionListResponse>(questionList);	
			//{
			//	Items = _mapper.Map<List<QuestionListItemDto>>(questionList),
			//	TotalCount = questionList.Count,
			//	PageNumber = request.PageNumber,
			//	PageSize = request.PageSize
			//};

			return response;


		}

		public UpdateQuestionResponse Update(UpdateQuestionRequest request)
		{
			Question? questionToUpdate = _questionDal.Get(predicate: question => question.Id == request.Id);
			_questionBusinessRules.CheckIfQuestionExists(questionToUpdate);

			questionToUpdate=_mapper.Map(request ,questionToUpdate);	
			Question updatedQuestion=_questionDal.Update(questionToUpdate);


			var response =_mapper.Map<UpdateQuestionResponse>(updatedQuestion);	
			return response;	

		}

	}
}
