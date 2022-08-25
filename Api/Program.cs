using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CullinaryBookContext>(option =>
{
    try
    {
        string connectionString = builder.Configuration.GetValue<string>("DefaultConnection");
        option.UseSqlServer(connectionString, b => b.MigrationsAssembly("Infrastructure.Migrations"));
    }
    catch (Exception)
    {
        
    }
});


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
