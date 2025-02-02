

using DataAccess.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Business.BusinessRules
{
	public class QuestionBusinessRules
	{
		public readonly IQuestionDal _questionDal;
		public void ValidateQuestionText(string questionText)
		{
			if (string.IsNullOrWhiteSpace(questionText))
			{
				throw new ValidationException("Soru metni boş bırakılamaz.");
			}
		}

	}
}
