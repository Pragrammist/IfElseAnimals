using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("animals/{animalId}/locations")]
public class AnimalLocationController : ControllerBase
{
    [HttpGet]
    public IActionResult Search(SearchAnimalLocationModel search)
    {
        return new ObjectResult(new AnimalLocationModel {
            
        });
    }


    [HttpPost("{pointId}")]
    public IActionResult Post(long pointId, long animalId)
    {
        return new ObjectResult(new AnimalLocationModel {
            
        });
    }

    [HttpPut]
    public IActionResult Put(UpdateAnimalLocationModel search)
    {
        return new ObjectResult(new AnimalLocationModel {
            
        });
    }

    [HttpDelete("{visitedPointId}")]
    public IActionResult Delete(long animalId, long visitedPointId)
    {
        return new ObjectResult(new AnimalLocationModel {
            
        });
    }
}
