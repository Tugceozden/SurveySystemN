namespace Business
{
	public class GetQuestionListRequest
	{

        public int? FilterBySurveyId { get; set; }
		public int PageNumber { get; set; } = 1; // Sayfalama için sayfa numarası
		public int PageSize { get; set; } = 10; // Sayfa başına kaç soru gösterilecek
		public string? SearchKeyword { get; set; }//sorular içinde arama yapmak için
	}
}