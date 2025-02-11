using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Participation:Entity<int>
	{
		public int PaticipantId { get; set; }
		public virtual Participant Participant { get; set; }
		public int? SurveyId { get; set; }
		public virtual Survey? Survey { get; set; }
		public string? Answers { get; set; }  
	}
}
