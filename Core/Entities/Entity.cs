using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
	public abstract class Entity<TId> : IEntity<TId>
	{
		public TId Id { get; set; }
		public DateTime CreatedAt { get ; set ; }
		public DateTime? UpdateAt { get ; set ; }
		public DateTime? DeletedAt { get ; set ; }
	}
	
}