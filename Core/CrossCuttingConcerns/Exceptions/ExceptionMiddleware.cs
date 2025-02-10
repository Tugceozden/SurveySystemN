

using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace Core.CrossCuttingConcerns.Exceptions
{
	public class ExceptionMiddleware
	{
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);   
            }
            catch (Exception ex) 
            { 
            await handleExceptionAsync(httpContext, ex);
            
            }

            


        }
		private Task handleExceptionAsync(HttpContext httpContext, Exception exception)
		{
            httpContext.Response.ContentType = MediaTypeNames.Application.Json;



            if(exception is BusinessException businessException)
				return createBusinessProblemDetailsResponse(httpContext, businessException);
            if (exception is NotFoundException notFoundException)
                return createNotFoundProblemDetailsResponse(httpContext, notFoundException);
              if(exception is ValidationException validationException) 
                return createValidationProblemDetailsResponse( httpContext, validationException); 

			return createInternalProblemDetailsResponse(httpContext,exception);
            
            
		}

		private  Task createValidationProblemDetailsResponse(HttpContext httpContext, ValidationException validationException)
		{
            httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            ValidationProblemDetails validationProblemDetails = new (
                title :"Validation Error",

                type:"http://doc.surveysystemn.com/validation-error",

                instance:httpContext.Request.Path,
                detail:"Please refer to the errors property for additional details.",

                errors:validationException.Errors.GroupBy
                (e=>e.PropertyName,e=>e.ErrorMessage)
                .ToDictionary(
                    failureGrup=>failureGrup.Key, 
                    failureGrup=>failureGrup.ToArray())
                


                )
            {
                Status = StatusCodes.Status400BadRequest
            };
            return httpContext.Response.WriteAsync(validationProblemDetails.ToString());
		}

		private Task createNotFoundProblemDetailsResponse(HttpContext httpContext, NotFoundException notFoundException)
 		{
            httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            NotFoundProblemDetails notFoundProblemDetails = new()
            {
                Title = "Not Found",
                Status= StatusCodes.Status404NotFound,  
                Detail=notFoundException.Message,
                Instance=httpContext.Request.Path
            };
            return httpContext.Response.WriteAsync(notFoundProblemDetails.ToString());
        }

		private Task createInternalProblemDetailsResponse(HttpContext httpContext, Exception exception)
		{
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            ProblemDetails problemDetails = new()
            {
                Title = exception.Message,
                Status = StatusCodes.Status500InternalServerError,
                Detail = exception.Message,
                Instance = httpContext.Request.Path


            };
            return httpContext.Response.WriteAsync(problemDetails.ToString());  
		}

		private Task createBusinessProblemDetailsResponse(HttpContext httpContext, BusinessException exception)
		{
            httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails problemDetails = new()
            {
                Title = "Business Exception",
                Status = StatusCodes.Status400BadRequest,
                Detail = exception.Message,
                Instance = httpContext.Request.Path




            };
            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(problemDetails)); 
		}
	}
}
