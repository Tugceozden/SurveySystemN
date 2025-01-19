namespace Business.Requests.Participant;

public class AddParticipantRequest
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Email { get; set; }

	public AddParticipantRequest(string name, string surname, string email)
	{
		Name = name ?? throw new ArgumentNullException(nameof(name));
		Surname = surname ?? throw new ArgumentNullException(nameof(surname));
		Email = email ?? throw new ArgumentNullException(nameof(email));
	}
}
