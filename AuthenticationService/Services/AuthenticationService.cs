using AuthenticationService.Models.Entities;
using Google.Protobuf.WellKnownTypes;
using GrpcAPIGatewayClient;

namespace AuthenticationService.Services;

public class AuthenticationService : IAuthenticationService
{
    public GetUsersRes GetUsers()
    {
        var users = new GetUsersRes();
       
        users.Users.Add(
            new GrpcAPIGatewayClient.User
            {
                UserId = 1,
                UserName = "Test",
                PasswordHash = Guid.NewGuid().ToString(),
                CreatedOn = Timestamp.FromDateTime(DateTime.UtcNow)
            });

        return users;
    }
}
