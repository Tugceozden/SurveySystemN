﻿using Core.DataAccess;
using Entities.Concrete;

public interface IUserDal : IEntityRepository<User, int>
{
}
