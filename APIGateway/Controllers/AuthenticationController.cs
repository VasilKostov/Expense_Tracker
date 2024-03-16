using APIGateway.Interfaces;
using APIGateway.Services;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcAPIGatewayClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace APIGateway.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : Controller
{
    private readonly IAuthenticationService _authService;
    public AuthenticationController(IAuthenticationService authService) 
    {
        _authService = authService;
    }

    [HttpGet("getUsers")]
    public async Task<GetUsersRes> GetUsers()
    {

        var res = await _authService.GetUsers();
        return res;
        //var reply = await client.SayHelloAsync(
        //                  new HelloRequest { Name = "GreeterClient" });
        //Console.WriteLine("Greeting: " + reply.Message);
        //Console.WriteLine("Press any key to exit...");
        //Console.ReadKey();
    }
}
