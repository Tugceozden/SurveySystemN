

using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Business.BusinessRules
{
	public class QuestionBusinessRules
	{
		private readonly IQuestionDal _questionDal;
        public QuestionBusinessRules(IQuestionDal questionDal)
        {
				_questionDal = questionDal;
        }
        public  void ValidateQuestionText(string questionText)
		{
			if (string.IsNullOrWhiteSpace(questionText))
			{
				throw new BusinessException("Soru metni boş bırakılamaz.");
			}
		}

		public void CheckIfQuestionExists(Question? questionToDelete)
		{

			if (questionToDelete == null) 
			{
				throw new BusinessException("Question not found.");
			
			}
		}
	}
}
