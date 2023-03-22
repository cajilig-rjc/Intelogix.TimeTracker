using Starshot.TimeTracker.Dtos;

namespace Starshot.TimeTracker.Responses
{
    public class CreateEmployeeResponse:ErrorDto
    {
        public int EmployeeId { get; set; }
    }
}
