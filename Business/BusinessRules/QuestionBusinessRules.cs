

using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
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

	}
}
