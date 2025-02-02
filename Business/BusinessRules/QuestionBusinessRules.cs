

using System.ComponentModel.DataAnnotations;

namespace Business.BusinessRules
{
	public class QuestionBusinessRules
	{
		public void ValidateQuestionText(string questionText)
		{
			if (string.IsNullOrWhiteSpace(questionText))
			{
				throw new ValidationException("Soru metni boş bırakılamaz.");
			}
		}

	}
}
