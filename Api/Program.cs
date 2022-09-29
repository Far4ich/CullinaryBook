using Infrastructure.Services;
using Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEntityFramework(connectionString);
builder.Services.AddApiServices();

var app = builder.Build();

app.MapControllers();

app.Run();

app.UseCors(x => x
    .WithOrigins("http://localhost:4200")
    .AllowCredentials()
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());