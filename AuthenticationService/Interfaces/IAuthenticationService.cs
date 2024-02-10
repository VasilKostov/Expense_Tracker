using AuthenticationService.Models.Entities;

namespace AuthenticationService.Services;

public interface IAuthenticationService
{
    public List<User> GetUsers();
}
