

using Business.Abstract;
using Business.Requests.User;
using Core.Entities;
using Core.Utilities.Security.Hashing;

namespace Business.Concrete
{
	public class UserManager:IUserService
	{

        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

		public bool Login(LoginRequest request)
		{
			User? user=_userDal.Get(i=>i.Email==request.Email);

			bool isPasswordCorrect = HashingHelper.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt); ;
			return isPasswordCorrect;	


		}

		public void Register(RegisterRequest request)
		{
			byte[] passwordSalt, passwordHash;
			HashingHelper.CreatePasswordHash(request.Password, out passwordSalt, out passwordHash);

			User user = new User();
			user.Email = request.Email;	
             user.PasswordSalt = passwordSalt;
			user.PasswordHash = passwordHash;	


			_userDal.Add(user);

		}
	}
}
