using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IParticipantDal
	{
		//CRUD - CREATE , UPDATE, DELETE, READ
		 public List<Participant> GetList();
		public Participant GetById( Guid id);
		 public void Add(Participant p);	
		public void Delete(Participant p);	
		public void Update(Participant p);




	}
}
