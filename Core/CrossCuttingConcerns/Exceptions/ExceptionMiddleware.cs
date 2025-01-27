﻿

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
            {
                return createBusinessProblemDetailsResponse(httpContext, businessException);

                return createInternalProblemDetailsResponse(httpContext,exception);
            }
            
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
            BusinessProblemDetails businessProblemDetails = new()
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
