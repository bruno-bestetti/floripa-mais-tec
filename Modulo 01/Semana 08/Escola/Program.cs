var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

//Exercício 01
//Crie um novo projeto com .NET usando o template WebAPI com o nome “Escola“
//Remova as classes WeatherForecastController.cs e WeatherForecastController.cs