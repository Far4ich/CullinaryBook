using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Migrations
{
    public class CullinaryBookContextFactory : IDesignTimeDbContextFactory<CullinaryBookContext>
    {
        public CullinaryBookContext CreateDbContext( string[] args )
        {
            IConfiguration configuration = CreateConfig();
            string connectionString = configuration.GetConnectionString( "DefaultConnection" );

            var optionsBuilder = new DbContextOptionsBuilder<CullinaryBookContext>();

            optionsBuilder.UseSqlServer(
                connectionString: connectionString,
                sqlServerOptionsAction: assembly => assembly.MigrationsAssembly( "Infrastructure.Migrations" ) );

            return new CullinaryBookContext( optionsBuilder.Options );
        }

        public IConfiguration CreateConfig() 
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath( Directory.GetCurrentDirectory() );
            builder.AddJsonFile( "migrationsettings.json", optional: false );

            return builder.Build();
        }
    }
}
