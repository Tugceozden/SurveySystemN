﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
	public class Entity<TId>
	{
        public TId Id { get; set; }
		 public DateTime CreatedAt { get; set; }
		 public DateTime? UpdateAt { get; set; }
		 public DateTime DeleteAt { get; set; }



    }
}
