namespace Business
{
	public class DeleteQuestionResponse
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeletedAt    { get; set; }
    }
}