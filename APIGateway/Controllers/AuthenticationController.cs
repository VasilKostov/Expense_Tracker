using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace APIGateway.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        Channel channel = new Channel("localhost:50052", ChannelCredentials.Insecure);
        var client = new AuthenticationService.AuthenticationServiceClient(channel);

        var response = await client.GetUsersAsync(new GetUsersRequest());

        return response.Users.ToList();
    }
}
