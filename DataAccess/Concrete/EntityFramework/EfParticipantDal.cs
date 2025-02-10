using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace DataAccess.Concrete.EntityFramework
{
	
	public class EfParticipantDal : IParticipantDal
	{
		private readonly SurveySystemContext _context;

		public EfParticipantDal(SurveySystemContext context)
		{
			_context = context;
		}

		public Participant Add(Participant entity)
		{
			_context.Participants.Add(entity);	
			_context.SaveChanges();
			return entity;	

		}

		public  Participant Delete(Participant entity,bool isSoftDelete = true)
		{
			entity.DeletedAt= DateTime.UtcNow;
			if (!isSoftDelete)

			_context.Participants.Remove(entity);	
			_context.SaveChanges();	
			return entity;	

		}

		public Participant? Get(Func<Participant, bool> predicate)
		{
			Participant? participant = _context.Participants.FirstOrDefault(predicate);
			return participant;


		}

		public IList<Participant> GetList(Func<Participant, bool>? predicate = null)
		{
			IQueryable<Participant>query= _context.Set<Participant>();	
			if(predicate != null)
				query=query.Where(predicate).AsQueryable();
			return query .ToList();	



		}

		public Participant Update(Participant entity)
		{
			entity.UpdateAt = DateTime.UtcNow;
			_context.Participants.Update(entity);	
			_context.SaveChanges ();
			return entity;	



		}
	}
}
