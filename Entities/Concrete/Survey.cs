using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Survey:Entity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Guid ParticipantId { get; set; }





		public virtual ICollection<Question> Questions { get; set; }
		public virtual Participant Participant { get; set; }
	}
}
