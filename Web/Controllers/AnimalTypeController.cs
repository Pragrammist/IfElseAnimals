using Microsoft.AspNetCore.Mvc;
using Web.DbContexts;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("animals/types/")]
public class AnimalTypeController : ControllerBase
{
    readonly OverallContext _context;
    public AnimalTypeController(OverallContext context)
    {
        _context = context;
    }

    [HttpGet("{typeId}")]
    public async Task<IActionResult> GetAsync(long typeId)
    {
        var ent = await _context.AnimalTypes.FindAsync(typeId);
        return new ObjectResult(ent.AdaptToModel());
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody]CreateAnimalTypeModel model)
    {
        var ent = model.AdaptToAnimalType();
        await _context.AnimalTypes.AddAsync(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent);
    }

    [HttpPut("{animalId}")]
    public async Task<IActionResult> PutAsync(long animalId, [FromBody]UpdateAnimalTypeModel model)
    {
        model.AnimalId = animalId;
        var ent = model.AdaptToAnimalType();
        _context.Update(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent);
    }

    [HttpDelete("{typeId}")]
    public async Task<IActionResult> DeleteAsync(long typeId)
    {
        var ent = await _context.AnimalTypes.FindAsync(typeId) ?? throw new Exception("");
        _context.AnimalTypes.Remove(ent);
        await _context.SaveChangesAsync();
        return new ObjectResult(ent);
    }
}
