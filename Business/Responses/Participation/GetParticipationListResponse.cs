

using Business.Dtos.Participation;

namespace Business.Responses.Participation
{
	public class GetParticipationListResponse
	{
		public ICollection<ParticipationListItemDto> Items { get; set; }  // Katılım listesi
		public int TotalCount { get; set; }  // Toplam katılım sayısı
		public int PageNumber { get; set; }  // Şu anki sayfa numarası
		public int PageSize { get; set; }  // Sayfada kaç katılım gösterileceği


	}
}
