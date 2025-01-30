

using Business.Requests.Question;

namespace Business.Abstract
{
	public  interface IQuestionService
	{

     public GetQuestionListResponse GetList(GetQuestionListRequest request);

     public GetQuestionByIdResponse GetById(GetQuestionListRequest request);

		public AddQuestionResponse Add(AddQuestionRequest request);
		public UpdateQuestionResponse Update(UpdateQuestionRequest request);
		public DeleteQuestionResponse Delete(DeleteQuestionRequest request);


	}
}
