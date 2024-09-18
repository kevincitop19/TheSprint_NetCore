using Microsoft.EntityFrameworkCore;
using POS.Infrastructura.Commons.Config.Context;
using POS.Infrastructura.Interface;
using POS.Infrastructura.Repository;

var builder = WebApplication.CreateBuilder(args);

//Crear conexion a la Base de Datos
var connectionString = builder.Configuration.GetConnectionString("POSConnection");
//Registar el servicio para la conexion
builder.Services.AddDbContext<PruebabackendContext>(options => options.UseSqlServer(connectionString));

// Registrando servicios y repositorios
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

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
