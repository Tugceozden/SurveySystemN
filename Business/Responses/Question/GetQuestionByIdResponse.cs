namespace Business
{
	public class GetQuestionByIdResponse
	{
		public string QuestionText { get; set; }
		public Guid SurveyId { get; set; }
		public int Order { get; set; }  // Sorunun anketteki sırası
		public string Options { get; set; }
		public string? Answer { get; set; }
		public string SurveyName { get; set; } // Anketin adı (isteğe bağlı)

	}
}