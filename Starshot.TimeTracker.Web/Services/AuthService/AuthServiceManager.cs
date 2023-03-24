using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Refit;
using Starshot.TimeTracker.Clients;
using Starshot.TimeTracker.Common.Security;
using Starshot.TimeTracker.Requests;
using Starshot.TimeTracker.Responses;
using System.IO;

namespace Starshot.TimeTracker.Web.Services.AuthService
{
    public class AuthServiceManager: IAuthServiceManager
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IAuthServiceClient _authServiceClient;
        private readonly NavigationManager _navigationManager;
        private const string Key = "x-auth";
        public AuthServiceManager(ILocalStorageService localStorageService, IAuthServiceClient authServiceClient,NavigationManager navigationManager)
        {
            _localStorageService = localStorageService;
            _authServiceClient = authServiceClient;
            _navigationManager = navigationManager;
            
        }
        public async Task<string?> GetTokenAsync()
        {
            var token = await _localStorageService.GetItemAsync<AuthResponse?>(Key);
            if (token == null)
                return null;
            if (DateTime.UtcNow > token.Expiry)
                _navigationManager.NavigateTo("/login");
            return $"Bearer {token.Token}";
        }
        public async Task<string?> GetNameAsync()
        {
            var name = await _localStorageService.GetItemAsync<AuthResponse?>(Key);
            if (name == null)
                return null;
            return name.UserName;
        }
        public async Task<bool> IsAuthenticatedAsync()
        {
            if (!await _localStorageService.ContainKeyAsync(Key))
                return false;
            var token = await _localStorageService.GetItemAsync<AuthResponse?>(Key);
            if (token == null)
                return false;
            if (DateTime.UtcNow > token.Expiry)
                return false;
            return true;
        }
        public async Task SignInAsync(string  username, string password,string path ="/")
        {
            try
            {
                //Todo:Get this key from azure keyvault 
                string key = "{0FA740C5-6134-456E-BCF3-53DECCC6A4BB}";
                var response = await _authServiceClient.AuthAsync(new AuthRequest
                {
                    UserName = username,
                    Password = AesCrypto.Encrypt(password,key)
                });
                await _localStorageService.SetItemAsync(Key, response);
                _navigationManager.NavigateTo(path);
            }
            catch { }
            
        }
        public async Task SignOutAsync()
        {
            await _localStorageService.RemoveItemAsync(Key);
            _navigationManager.NavigateTo("/login");
        }
    }
}
