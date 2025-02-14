

using Business.Abstract;
using Business.Requests.User;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;

namespace Business.Concrete
{
	public class UserManager:IUserService
	{

        private readonly IUserDal _userDal;
		private readonly ITokenHelper _tokenHelper;
        
				
        
        public UserManager(IUserDal userDal, ITokenHelper tokenHelper)
        {
            _userDal = userDal;
			_tokenHelper = tokenHelper;
        }

		public AccessToken Login(LoginRequest request)
		{
			User? user=_userDal.Get(i=>i.Email==request.Email);

			bool isPasswordCorrect = HashingHelper.VerifyPassword(request.Password,
				user.PasswordHash, user.PasswordSalt); ;

			if (!isPasswordCorrect)
				throw new  Exception("Şifre yanlış.");


			return _tokenHelper.CreateToken(user);



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
