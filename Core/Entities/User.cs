﻿namespace Core.Entities
{
	public class User : Entity<int>
	{
		public string Email { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
	}
}
