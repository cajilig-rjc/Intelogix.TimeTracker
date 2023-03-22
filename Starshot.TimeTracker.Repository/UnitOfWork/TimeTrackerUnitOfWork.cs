using Starshot.TimeTracker.Data;
using Starshot.TimeTracker.Data.Models;

namespace Starshot.TimeTracker.Repository.UnitOfWork
{
    public class TimeTrackerUnitOfWork:ITimeTrackerUnitOfWork
    {
        private readonly TimeTrackerDbContext _context;
        public TimeTrackerUnitOfWork(TimeTrackerDbContext context)
        {
            _context = context;
        }
        public IGenericTimeTrackerRepository<Employee> EmployeeRepository => new GenericTimeTrackerRepository<Employee>(_context);
        public IGenericTimeTrackerRepository<TimeSheet> TimeSheetRepository => new GenericTimeTrackerRepository<TimeSheet>(_context);
        public IGenericTimeTrackerRepository<User> UserRepository => new GenericTimeTrackerRepository<User>(_context);

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
