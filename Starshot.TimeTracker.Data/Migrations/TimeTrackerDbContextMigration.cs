using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Starshot.TimeTracker.Data.Migrations
{
    internal class TimeTrackerDbContextMigration : IDesignTimeDbContextFactory<TimeTrackerDbContext>
    {
        public TimeTrackerDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TimeTrackerDbContext> optionsBuilder = new DbContextOptionsBuilder<TimeTrackerDbContext>()
          .UseSqlServer("Server=RC-17;Database=TimeTrackerDb;Trusted_Connection=True;TrustServerCertificate=True;");
           var settings = new Dictionary<string, string> {
           {"Security:Key", "3c422d85-b07e-4aa2-8a17-b10cddf3e922"}};

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(settings)
                .Build();
            return new TimeTrackerDbContext(optionsBuilder.Options,configuration);
        }
    }
}
