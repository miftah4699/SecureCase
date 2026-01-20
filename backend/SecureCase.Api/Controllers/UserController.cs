using Microsoft.AspNetCore.Mvc;
using SecureCase.Application.UseCases;

namespace SecureCase.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly RegisterUser _registerUser;

    public UsersController(RegisterUser registerUser)
    {
        _registerUser = registerUser;
    }

    [HttpPost]
    public async Task<IActionResult> Register(string email)
    {
        await _registerUser.ExecuteAsync(email);
        return Ok();
    }
}
