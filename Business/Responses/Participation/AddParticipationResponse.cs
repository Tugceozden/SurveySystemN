namespace Business.Responses.Participation
{
	public class AddParticipationResponse
	{
		public int Id { get; set; } // Katılımın ID'si
		public int UserId { get; set; } // Katılım yapan kullanıcının ID'si
		public int SurveyId { get; set; } // Katılım yapılan anketin ID'si
		public DateTime ParticipationDate { get; set; } // Katılım tarihi
		public bool Success { get; set; } // İşlem başarılı mı
		public string Message { get; set; } // Durum mesajı



		public AddParticipationResponse(int id, int userId, int surveyId, DateTime participationDate, bool success, string message)
		{
			Id = id;
			UserId = userId;
			SurveyId = surveyId;
			ParticipationDate = participationDate;
			Success = success;
			Message = message;
		}





	}
}
