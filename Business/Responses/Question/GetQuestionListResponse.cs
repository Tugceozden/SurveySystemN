using Business.Dtos.Question;

namespace Business
{
	public class GetQuestionListResponse
	{

		public ICollection<QuestionListItemDto> Items { get; set; }
		public int TotalCount { get; set; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }

	}
}