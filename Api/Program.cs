using Infrastructure.Services;
using Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEntityFramework(connectionString);
builder.Services.AddApiServices();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
