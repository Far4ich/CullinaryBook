using Api.Services;
using Domain.RecipeEntity;
using Domain.UoW;
using Infrastructure.Data.RecipeModel;
using Infrastructure.Services;
using Infrastructure.UoW;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEntityFramework(connectionString);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
