using Starshot.TimeTracker.Dtos;

namespace Starshot.TimeTracker.Responses
{
    public class SearchEmployeeResponse:ErrorDto
    {
        public int? Result { get; set; }
        public IEnumerable<ReadEmployeeDto>? Employees { get; set; }
    }
}
