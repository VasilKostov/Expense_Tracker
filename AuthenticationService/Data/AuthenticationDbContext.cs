using GrpcAPIGatewayClient;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.Data;

public class AuthenticationDbContext : DbContext
{
    public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> dbContextOptions) : base(dbContextOptions)
    {
        //try
        //{
        //    var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;

        //    if (databaseCreator is not null)
        //    {
        //        if (!databaseCreator.CanConnect())
        //            databaseCreator.Create();
        //        if (!databaseCreator.HasTables())
        //            databaseCreator.CreateTables();
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.ToString());
        //}
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
    //    if (!options.IsConfigured)
    //        options.UseSqlServer("Data Source=localhost,8001;Initial Catalog=Authentication;User Id=sa;Password=Exp3nse_Tracker024;Encrypt=True;TrustServerCertificate=True;", b => b.MigrationsAssembly("AuthenticationService"));
    //}
    public DbSet<User> Users { get; set; }
}
