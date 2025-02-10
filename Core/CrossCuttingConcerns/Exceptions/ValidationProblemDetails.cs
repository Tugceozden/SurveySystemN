

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core.CrossCuttingConcerns.Exceptions
{
	public class ValidationProblemDetails:ProblemDetails
	{
        public IDictionary<string, string[]> Errors {  get; set; }  


        public ValidationProblemDetails()
        {
                Errors = new Dictionary<string, string[]>();    
        }
        public ValidationProblemDetails(string type ,string detail,string title,string instance,IDictionary<string, string[]> errors)
        {
            Type = type;
            Detail = detail;    
            Title = title;  
            Errors = errors;
        }
		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);  
		}

	}
}
