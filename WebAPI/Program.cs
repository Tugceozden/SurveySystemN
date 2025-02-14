using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<IParticipantService, ParticipantManager>();
//builder.Services.AddSingleton<IParticipantDal, InMemoryParticipantDal>();
//builder.Services.AddSingleton<ParticipantBusinessRules>();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddBusinessServices(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


TokenOptions? tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services
.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
	options.TokenValidationParameters = new TokenValidationParameters()
	{
		 ValidateIssuer=true,
		 ValidateAudience=true,
		ValidIssuer=tokenOptions.Issuer,
		ValidAudience=tokenOptions.Audience,
		ValidateLifetime=true,
		ValidateIssuerSigningKey=true,
		IssuerSigningKey=new SymmetricSecurityKey
		(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))



	};
}



);

var app = builder.Build();
//if(app.Environment.IsProduction())
app.UseGlobalExceptionHandling();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.UseMiddleware<ExceptionMiddleware>();


app.Run();
