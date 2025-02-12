

using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace Business.DependencyResolvers
{
	public static class ServiceCollectionBusinessExtension
	{


		public static IServiceCollection AddBusinessServices(this IServiceCollection services,IConfiguration configuration) 
		
		{

				services.AddScoped<IParticipantService, ParticipantManager>();
				services.AddScoped<IParticipantDal, EfParticipantDal>();
				services.AddScoped<ParticipantBusinessRules>();


			    services.AddScoped<IQuestionService, QuestionManager>()
				.AddScoped<IQuestionDal,EfQuestionDal>()
				.AddScoped<QuestionBusinessRules>();

			services.AddScoped<IParticipationService, ParticipationManager>()
				.AddScoped<IParticipationDal, EfParticipationDal>()
				.AddScoped<ParticipationBusinessRules>();

			


			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			services.AddDbContext<SurveySystemContext>(options => options.UseSqlServer(configuration.GetConnectionString("SurveySystemMSSQL22")));	

				return services;


			



		}

		

	}
}
