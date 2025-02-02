

using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
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
			throw new NotImplementedException();
		}

		public GetQuestionByIdResponse GetById(GetQuestionByIdRequest request)
		{
			throw new NotImplementedException();
		}

		public GetQuestionListResponse GetList(GetQuestionListRequest request)
		{

			var questionList = _questionDal.GetList();
		}

		public UpdateQuestionResponse Update(UpdateQuestionRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
