using Microsoft.EntityFrameworkCore;
using POS.Infrastructura.Commons.Config.Context;
using POS.Infrastructura.Extension;
using POS.Infrastructura.Interface;
using POS.Infrastructura.Repository;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

//Inyectar Servicios
builder.Services.AddInjectionInfrastructura(Configuration);

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
