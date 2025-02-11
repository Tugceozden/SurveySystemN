

namespace Business.Responses.Participation
{
	public class UpdateParticipationResponse
	{
		public int Id { get; set; }  // Katılımın ID'si
		public int UserId { get; set; }  // Katılım yapan kullanıcının ID'si
		public int SurveyId { get; set; }  // Katılım yapılan anketin ID'si
		public DateTime ParticipationDate { get; set; }  // Katılım tarihi
		public string Status { get; set; }  // Katılımın güncellenen durumu (Tamamlandı, İptal Edildi vs.)
		public DateTime UpdatedAt { get; set; }  // Güncelleme tarihi
	}
}
