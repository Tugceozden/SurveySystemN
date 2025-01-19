
namespace Business.Responses.Participant
{
	public class AddParticipantResponse
	{
		public int UserId { get; set; }	
		public string Name { get; set; }	
		public string Surname { get; set; }	
		public string Email { get; set; }
        public DateTime CreatedAt { get; set; }	

        public AddParticipantResponse(int userId, string name, string email,string surname)
		{
			UserId = userId;	
			Name = name;	
			Email = email;	
			Surname = surname;	


		}



	}
}
