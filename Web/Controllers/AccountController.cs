using Microsoft.AspNetCore.Mvc;
using Web.DbContexts;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("accounts")]
public class AccountController : ControllerBase
{

    readonly OverallContext _context;
    public AccountController(OverallContext context)
    {
        _context = context;
    }
    [HttpGet("{accountId}")]
    public IActionResult Get(int accountId)
    {
        return new ObjectResult(new AccountModel {
            Id = 1,
            FirstName = "",
            LastName = "",
            Email = ""
        });
    }
    [HttpGet("search")]
    public IActionResult Search([FromQuery]SearchAccountModel search)
    {
        return new ObjectResult(new AccountModel {
            Id = 1,
            FirstName = "",
            LastName = "",
            Email = ""
        });
    }
    [HttpPut("{accountId}")]
    public IActionResult Put([FromBody]UpdateAccountModel update)
    {
        return new ObjectResult(new AccountModel {
            Id = 1,
            FirstName = "",
            LastName = "",
            Email = ""
        });
    }
    [HttpDelete("{accountId}")]
    public IActionResult Delete(int accountId)
    {
        return Ok();
    }
}
