using APIGateway.Interfaces;
using Grpc.Net.Client;
using GrpcAPIGatewayClient;

namespace APIGateway.Services;

public class AuthenticationService : IAuthenticationService
{
    //private RPCCLient _rPC
    private readonly Authentication.AuthenticationClient _client;
    public AuthenticationService(Authentication.AuthenticationClient client)
    {
        _client = client;
    }

    public async Task<GetUsersRes> GetUsers()
    {
        //var channel = GrpcChannel.ForAddress("http://localhost:8003/");
        //var client = new Authentication.AuthenticationClient(channel);

        return await _client.GetUsersAsync(new GetUsersReq());
    }
}
