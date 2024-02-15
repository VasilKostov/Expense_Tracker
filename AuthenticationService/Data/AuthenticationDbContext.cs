using GrpcAPIGatewayClient;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.Data;

public class AuthenticationDbContext : DbContext
{
    public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> dbContextOptions) : base(dbContextOptions) { }
    public DbSet<User> Users { get; set; }
}
