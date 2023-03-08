using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    [HttpPost("registration")]
    public async Task<IActionResult> PostAsync([FromBody]CreateAcountModel acount)
    {
        var ent = acount.AdaptToAcount();
        await _context.Accounts.AddAsync(ent);
        await _context.SaveChangesAsync();
        
        return new ObjectResult(ent.AdaptToAccountModel());
    }

    [HttpGet("{accountId}")]
    public async Task<IActionResult> GetAsync(int accountId)
    {
        var ent = await _context.Accounts.FindAsync(accountId);
        return new ObjectResult(ent.AdaptToAccountModel());
    }
    [HttpGet("search")]
    public async Task<IActionResult> SearchAsync([FromQuery]SearchAccountModel search)
    {
        var ent = await _context.Accounts.FirstOrDefaultAsync(ac => search.BuildSearch(ac));
        return new ObjectResult(ent.AdaptToAccountModel());
    }
    [HttpPut("{accountId}")]
    public async Task<IActionResult> PutAsync(int accountId, [FromBody]UpdateAccountModel update)
    {
        var ent = await _context.Accounts.FindAsync(accountId) ?? throw new Exception("");
        update.UpdateEntity(ent);
        _context.Accounts.Update(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent.AdaptToAccountModel());
    }
    [HttpDelete("{accountId}")]
    public async Task<IActionResult> DeleteAsync(int accountId)
    {
        var ent = await _context.Accounts.FindAsync(accountId) ?? throw new Exception("");
        _context.Accounts.Remove(ent);
        return new ObjectResult(ent.AdaptToAccountModel());
    }
}
