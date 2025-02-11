using Core.Entities;
using Entities.Concrete;

public class Participant : Entity<int>
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public int Age { get; set; }
	public string City { get; set; }
	public string Email { get; set; }

	// Foreign Key
	public int UserID { get; set; } // Guid yerine int yaptık
	public virtual User User { get; set; }

	public virtual ICollection<SurveyResult> SurveyResults { get; set; }

	public Participant()
	{
		SurveyResults = new List<SurveyResult>();
	}

	public Participant(string name, string surname, string email) : this()
	{
		Name = name;
		Surname = surname;
		Email = email;
	}
}
