﻿using GrpcAPIGatewayClient;

namespace AuthenticationService.Services;

public interface IAuthenticationService
{
    public GetUsersRes GetUsers();
}
