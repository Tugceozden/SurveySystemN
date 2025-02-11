using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
	public class EfParticipationDal : IParticipationDal
	{
		private readonly SurveySystemContext _context;
        public EfParticipationDal(SurveySystemContext context)
        {
				_context = context;
        }
        public Participation Add(Participation entity)
		{
			entity.CreatedAt = DateTime.UtcNow;
			_context.Participations.Add(entity);
			_context.SaveChanges();
			return entity;

		}

		public Participation Delete(Participation entity, bool isSoftDelete = true)
		{
			entity.DeletedAt = DateTime.UtcNow;
			if (!isSoftDelete)

				_context.Participations.Remove(entity);
			_context.SaveChanges();
			return entity;
		}

		public Participation? Get(Func<Participation, bool> predicate)
		{
			Participation? participation = _context.Participations.FirstOrDefault(predicate);
			return participation;
		}

		public IList<Participation> GetList(Func<Participation, bool>? predicate = null)
		{
			IQueryable<Participation> query = _context.Set<Participation>();
			if (predicate != null)
				query = query.Where(predicate).AsQueryable();
			return query.ToList();
		}

		public Participation Update(Participation entity)
		{
			entity.UpdateAt = DateTime.UtcNow;
			_context.Participations.Update(entity);
			_context.SaveChanges();
			return entity;
		}
	}
}
