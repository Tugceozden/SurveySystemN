using Business.Requests.Question;
using FluentValidation;

namespace Business.Profiles.Validation.FluentValidation.Question
{
	public class AddQuestionRequestValidator : AbstractValidator<AddQuestionRequest>
	{
		public AddQuestionRequestValidator()
		{
			// 1️⃣ SurveyId boş olamaz ve 0'dan büyük olmalı
			RuleFor(x => x.SurveyId)
				.NotEmpty().WithMessage("Anket ID boş olamaz!")
				.GreaterThan(0).WithMessage("Anket ID 0'dan büyük olmalıdır!");

			// 2️⃣ QuestionText boş olamaz ve en az 5, en fazla 500 karakter olmalı
			RuleFor(x => x.QuestionText)
				.NotEmpty().WithMessage("Soru metni boş olamaz!")
				.MinimumLength(5).WithMessage("Soru metni en az 5 karakter olmalıdır!")
				.MaximumLength(500).WithMessage("Soru metni en fazla 500 karakter olabilir!");

			// 3️⃣ Order sırası 0 veya negatif olamaz
			RuleFor(x => x.Order)
				.GreaterThan(0).WithMessage("Soru sırası 0'dan büyük olmalıdır!");

			// 4️⃣ Options boş olamaz
			RuleFor(x => x.Options)
				.NotEmpty().WithMessage("Seçenekler boş olamaz!");

			// 5️⃣ Answer boş olabilir ama maksimum 255 karakter olmalı
			RuleFor(x => x.Answer)
				.MaximumLength(255).WithMessage("Cevap en fazla 255 karakter olabilir!");
		}
	}
}
