using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("animals/types/")]
public class AnimalTypeController : ControllerBase
{
    [HttpGet("{typeId}")]
    public IActionResult Get(long typeId)
    {
        return new ObjectResult(new AnimalTypeModel {
            Id = 1,
            Type = ""
        });
    }

    [HttpPost]
    public IActionResult Post([FromBody]CreateAnimalTypeModel model)
    {
        return new ObjectResult(new AnimalTypeModel {
            Id = 1,
            Type = ""
        });
    }

    [HttpPut]
    public IActionResult Put([FromBody]UpdateAnimalTypeModel model)
    {
        return new ObjectResult(new AnimalTypeModel {
            Id = 1,
            Type = ""
        });
    }

    [HttpDelete("{typeId}")]
    public IActionResult Delete(long typeId)
    {
        return new ObjectResult(new AnimalTypeModel {
            Id = 1,
            Type = ""
        });
    }
}
