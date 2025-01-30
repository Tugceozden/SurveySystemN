using Core.Entities;
using Entities.Concrete;

public class Participant : Entity<int>
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public int Age { get; set; }
	public string City { get; set; }
	public string Email { get; set; }
	public Guid UserID { get; set; }
	public virtual ICollection<SurveyResult> SurveyResults { get; set; }
	public virtual User User { get; set; }

	// Parametresiz Constructor
	public Participant()
	{
		UserID = Guid.NewGuid(); // Varsayılan olarak yeni bir GUID oluşturur
		SurveyResults = new List<SurveyResult>(); // Null referans hatasını önler
	}

	// Parametreli Constructor
	public Participant(string name, string surname, string email) : this() // Varsayılan constructor'ı çağırır
	{
		Name = name;
		Surname = surname;
		Email = email;
	}
}
