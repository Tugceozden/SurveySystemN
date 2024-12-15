﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Question
	{
		public string QuestionText { get; set; }
		public Guid SurveyId { get; set; }
		public int Order { get; set; }  // Sorunun anketteki sırası
		public string Options { get; set; }
		public string? Answer { get; set; }


		public virtual Survey Survey { get; set; }
	}
}