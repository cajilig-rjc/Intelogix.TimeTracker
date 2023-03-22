using Starshot.TimeTracker.Dtos;

namespace Starshot.TimeTracker.Responses
{
    public class GetEmployeeResponse:ErrorDto
    {
        public ReadEmployeeDto Employee { get; set; }
    }
}
