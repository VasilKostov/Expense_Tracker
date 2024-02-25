using APIGateway.DTOs.ConfigurationDTOs;

namespace APIGateway.Singletons;

public class Configuration
{
    public List<GrpcClientURLs> GrpcClientURLs { get; set; } = new List<GrpcClientURLs>();
}
