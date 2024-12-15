using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Participation
	{
		public Guid PaticipantId { get; set; }
		public virtual Participant Participant { get; set; }
		public Guid? SurveyId { get; set; }
		public virtual Survey? Survey { get; set; }
		public string? Answers { get; set; }  
	}
}
