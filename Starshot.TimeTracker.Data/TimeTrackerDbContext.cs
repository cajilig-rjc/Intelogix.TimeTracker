using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Starshot.TimeTracker.Data.Configs;
using Starshot.TimeTracker.Data.Models;

namespace Starshot.TimeTracker.Data
{
    public class TimeTrackerDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options,IConfiguration configuration) : base(options) { _configuration = configuration; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfig());
            builder.ApplyConfiguration(new TimeSheetConfig());
            builder.ApplyConfiguration(new UserConfig(_configuration));
        }
    }
}
