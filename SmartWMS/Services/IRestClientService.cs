using SmartWMS.DTO.Models;
using SmartWMS.DTO.VirtualModels;

namespace SmartWMS.Services
{
    public interface IRestClientService
    {
        Task<bool> LoginAsync(Login login);
        Task<bool> LogoutAsync();
        Task<RootData<T>> RestServiceGetAsync<T>(string model, int offset = 0, int limit = 10);
        Task<RootData<T>> RestServiceSearchAsync<T>(string model, SearchRequest search, int offset = 0, int limit = 10);
    }
}