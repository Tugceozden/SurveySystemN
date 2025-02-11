using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class SurveyResult:Entity<int>
	{
		public int? SurveyId { get; set; }
		public int ParticipantId { get; set; }


		public virtual Survey? Survey { get; set; }
		public virtual Participant Participant { get; set; }


	}
}
