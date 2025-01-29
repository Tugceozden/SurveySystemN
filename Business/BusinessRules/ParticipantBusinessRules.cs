

using Core.CrossCuttingConcerns.Exceptions;
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
			bool isExists = _participantDal.Get(participant => participant.Name == participantName)is not null;

			
				if (isExists)
				{
					throw new BusinessException("Participant already Exists");


				}

			

		}
	}
}
