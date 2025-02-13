using Core.DataAccess;
using Core.Entities;

public interface IUserDal : IEntityRepository<User, int>
{
}
