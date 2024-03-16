using GrpcAPIGatewayClient;

namespace APIGateway.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<GetUsersRes> GetUsers();
    }
}
