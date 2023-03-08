using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("animals")]
public class AnimalController : ControllerBase
{
    [HttpGet("{animalId}")]
    public IActionResult Get(long animalId)   
    {
        return new ObjectResult(new AnimalModel {

        });
    }

    [HttpGet("search")]
    public IActionResult Search(SearchAnimalModel search)   
    {
        return new ObjectResult(new AnimalModel {
            
        });
    }

    [HttpPost]
    public IActionResult Post([FromBody]CreateAnimalModel search)   
    {
        return new ObjectResult(new AnimalModel {
            
        });
    }

    [HttpPut("{animalId}")]
    public IActionResult Put([FromBody]CreateAnimalModel search)   
    {
        return new ObjectResult(new AnimalModel {
            
        });
    }

    [HttpDelete("{animalId}")]
    public IActionResult Delete(long animalId)   
    {
        return new ObjectResult(new AnimalModel {
            
        });
    }

    [HttpPost("{animalId}/types/{typeId}")]
    public IActionResult PostAnimalType(long animalId, long typeId)   
    {
        return new ObjectResult(new AnimalModel {
            
        });
    }

    [HttpPut("{animalId}/types")]
    public IActionResult PutAnimalType([FromBody]UpdateAnimalTypeModel search)   
    {
        return new ObjectResult(new AnimalModel {
            Id = search.Id
        });
    }

    [HttpDelete("{animalId}/types/{typeId}")]
    public IActionResult DeleteAnimalType(long animalId, long typeId)   
    {
        return new ObjectResult(new AnimalModel {
            
        });
    }
}
