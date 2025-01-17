

using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
	public class ParticipantBusinessRules
	{
		private readonly IParticipantDal _participantDal;


		public ParticipantBusinessRules(IParticipantDal participantDal)
		{
			_participantDal = participantDal;
		}


		public void CheckIfParticipantNameNotExists(string participantName)
	{
			bool isExists = _participantDal.GetList().Any(p => p.Name == participantName);
			if (isExists)
			{
				throw new Exception("Participant already Exists");


			}

		}
	}
}
