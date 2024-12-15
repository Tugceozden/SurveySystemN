using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class User
	{
		public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = default!;

	}
}
