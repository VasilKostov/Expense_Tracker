using AuthenticationService.Models.Entities;

namespace AuthenticationService.Services;

public class AuthenticationService : IAuthenticationService
{
    public List<User> GetUsers()
    {
        return
        [
            new User 
            {
                UserId = 1,
                UserName = "Test",
                PasswordHash = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now
            } 
        ];
    }
}
