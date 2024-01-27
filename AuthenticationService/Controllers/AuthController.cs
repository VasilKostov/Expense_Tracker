using AuthenticationService.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : Controller
{
    private readonly AuthenticationDbContext _authDbContext;
    public AuthController(AuthenticationDbContext authDbContext)
    {
        _authDbContext = authDbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Users>> GetUsers()
    {
        return _authDbContext.Users;
    }
}
