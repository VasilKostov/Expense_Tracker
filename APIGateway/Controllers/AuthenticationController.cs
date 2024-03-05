﻿using APIGateway.Services;
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
    public AuthenticationController() { }

    [HttpGet("getUsers")]
    public async Task<GetUsersRes> GetUsers()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:8081");
        var client = new Authentication.AuthenticationClient(channel);

        return await client.GetUsersAsync(new GetUsersReq());

        //var reply = await client.SayHelloAsync(
        //                  new HelloRequest { Name = "GreeterClient" });
        //Console.WriteLine("Greeting: " + reply.Message);
        //Console.WriteLine("Press any key to exit...");
        //Console.ReadKey();
    }
}
