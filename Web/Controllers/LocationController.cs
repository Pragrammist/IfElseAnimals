using Microsoft.AspNetCore.Mvc;
using Web.DbContexts;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("locations")]
public class LocationController : ControllerBase
{
    readonly OverallContext _context;
    public LocationController(OverallContext context)
    {
        _context = context;
    }
    [HttpGet("{pointId}")]
    public async Task<IActionResult> GetAsync(long pointId)
    {
        var ent = await _context.LocationPoints.FindAsync(pointId) ?? throw new Exception();
        return new ObjectResult(ent.AdaptToModel());
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody]CreateLocationModel model)
    {
        var ent = model.AdaptToLocationPoint();
        await _context.LocationPoints.AddAsync(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent.AdaptToModel());
    }
    [HttpPut("{pointId}")]
    public async Task<IActionResult> PutAsync(long pointId, [FromBody]UpdatedLocationModel model)
    {
        model.PointId = pointId;
        var ent = model.AdaptToLocationPoint();
        _context.LocationPoints.Update(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent.AdaptToModel());
    }
    [HttpDelete("{pointId}")]
    public async Task<IActionResult> DeleteAsync(long pointId)
    {
        var ent = await _context.LocationPoints.FindAsync(pointId) ?? throw new Exception();
        _context.Remove(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent.AdaptToModel());
    }
}




[ApiController]
[Route("registration")]
public class AuthController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }
    
}