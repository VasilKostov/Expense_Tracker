using AuthenticationService.Data;
using AuthenticationService.Models;
using AuthenticationService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _authDbContext.Users.ToListAsync();
    }


    public ActionResult<User> GetUser(string username, string password)
    {
        //hash the pass and check for some security bridge
        return _authDbContext.Users.Where(u=>u.UserName == username && u.PasswordHash == password).FirstOrDefault();
    }
}
