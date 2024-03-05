using Grpc.Core;
using GrpcAPIGatewayServer;

namespace AuthenticationService.Services;

public class AuthenticationService : Authentication.AuthenticationBase
{
    public AuthenticationService()
    {
    }

    public override Task<GetUsersRes> GetUsers(GetUsersReq req, ServerCallContext context)
    {
        return Task.FromResult(new GetUsersRes());
    }
}
