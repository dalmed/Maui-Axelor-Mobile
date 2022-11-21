using SmartWMS.DTO.Models;

namespace SmartWMS.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(string code, CancellationToken cancellationToken = default);
    }
}