namespace Business
{
	public class UpdateQuestionResponse
	{
		public int Id { get; set; }
		public string QuestionText { get; set; }
		public Guid SurveyId { get; set; }
		public int Order { get; set; }  // Sorunun anketteki sırası
		public string Options { get; set; }
		public string? Answer { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}