using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.DependencyResolvers;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<IParticipantService, ParticipantManager>();
//builder.Services.AddSingleton<IParticipantDal, InMemoryParticipantDal>();
//builder.Services.AddSingleton<ParticipantBusinessRules>();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddBusinessServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
