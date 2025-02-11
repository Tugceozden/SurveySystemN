

namespace Business.Responses.Participation
{
	public class GetParticipationByIdResponse
	{
		public int Id { get; set; }  // Katılım ID'si
		public int UserId { get; set; }  // Katılım yapan kullanıcının ID'si
		public int SurveyId { get; set; }  // Katılım yapılan anketin ID'si
		public DateTime ParticipationDate { get; set; }  // Katılım tarihi
		public string ParticipantName { get; set; }  // Katılım yapan kişinin adı
		public string SurveyName { get; set; }  // Anketin adı
		public string Status { get; set; }  // Katılım durumu (örneğin: tamamlandı, bekliyor)
		public string Message { get; set; }  // Katılım hakkında ek mesaj (opsiyonel)
	}
}
