using Starshot.TimeTracker.Requests;
using Starshot.TimeTracker.Responses;

namespace Starshot.TimeTracker.Core.Services.AuthService
{
    public interface  IAuthServiceManager
    {
        Task<AuthResponse> AuthAsync(AuthRequest request);
    }
}
