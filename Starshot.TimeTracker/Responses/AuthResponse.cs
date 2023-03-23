using Starshot.TimeTracker.Dtos;

namespace Starshot.TimeTracker.Responses
{
    public class AuthResponse:ErrorDto
    {
        public string Token { get; set; }
        public DateTime Expiry { get; set; }
        public int Id { get; set; }

    }
}
