using Refit;
using Starshot.TimeTracker.Requests;
using Starshot.TimeTracker.Responses;

namespace Starshot.TimeTracker.Clients
{
    public interface IAuthServiceClient
    {
        [Post("/api/auth")]
        Task<AuthResponse> AuthAsync([Body]AuthRequest request);
    }
}
