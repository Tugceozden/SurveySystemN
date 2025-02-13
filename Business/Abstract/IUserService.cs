

using Business.Requests.User;

namespace Business.Abstract
{
	public interface IUserService
	{

		void Register(RegisterRequest request);

    }
}
