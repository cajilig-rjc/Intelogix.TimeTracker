using Starshot.TimeTracker.Data.Models;

namespace Starshot.TimeTracker.Repository.UnitOfWork
{
    public interface ITimeTrackerUnitOfWork
    {
        IGenericTimeTrackerRepository<Employee> EmployeeRepository { get; }
        IGenericTimeTrackerRepository<TimeSheet> TimeSheetRepository { get; }
        IGenericTimeTrackerRepository<User> UserRepository { get; }
        Task<int> SaveChangesAsync();

    }
}
