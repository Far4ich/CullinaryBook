using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            new CullinaryBookContextFactory().CreateDbContext(new string[] { }).Database.Migrate();
        }
    }
}