using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using  Core.Entities; // Core.Entities eklendi


namespace Entities.Concrete
{
	public  class Participant:Entity<int>
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string City { get; set; }
		public string Email { get; set; }
		public Guid UserID { get; set; }

		public Participant()
		{

		}

		public Participant (string name,string surname,string email)
		{
			Name = name;
			Surname = surname;
			Email = email;	


		}

		public virtual ICollection<SurveyResult> SurveyResults { get; set; }
		public virtual User User { get; set; }
	}
}
