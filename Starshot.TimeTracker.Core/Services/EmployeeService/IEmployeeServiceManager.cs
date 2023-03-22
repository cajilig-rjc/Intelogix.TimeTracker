using Starshot.TimeTracker.Requests;
using Starshot.TimeTracker.Responses;

namespace Starshot.TimeTracker.Core.Services.EmployeeService
{
    public interface IEmployeeServiceManager
    {
        Task<SearchEmployeeResponse> SearchAsync(SearchEmployeeRequest request);
        Task<GetEmployeeResponse> GetAsync(GetEmployeeRequest request);
        Task<CreateEmployeeResponse> CreateAsync(CreateEmployeeRequest request);
        Task<UpdateEmployeeResponse> UpdateAsync(UpdateEmployeeRequest request);
        Task<CreateTimeSheetResponse> CreateTimeSheetAsync(CreateTimeSheetRequest request);
    }
}
