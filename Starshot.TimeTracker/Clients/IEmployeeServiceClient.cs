using Refit;
using Starshot.TimeTracker.Requests;
using Starshot.TimeTracker.Responses;

namespace Starshot.TimeTracker.Clients
{
    public interface IEmployeeServiceClient
    {
        [Get("")]
        Task<SearchEmployeeResponse> SearchAsync(SearchEmployeeRequest request);
        [Get("")]
        Task<GetEmployeeResponse> GetAsync(GetEmployeeRequest request);
        [Post("")]
        Task<CreateEmployeeResponse> CreateAsync(CreateEmployeeRequest request);
        [Put("")]
        Task<UpdateEmployeeResponse> UpdateAsync(UpdateEmployeeRequest request);
        [Post("")]
        Task<CreateTimeSheetResponse> CreateTimeSheetAsync(CreateTimeSheetRequest request);
    }
}
