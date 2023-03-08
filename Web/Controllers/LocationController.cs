using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("locations")]
public class LocationController : ControllerBase
{
    [HttpGet("{pointId}")]
    public IActionResult Get(long pointId)
    {
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
    [HttpPost]
    public IActionResult Post([FromBody]CreateLocationModel model)
    {
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
    [HttpPut("{pointId}")]
    public IActionResult Put([FromBody]UpdatedLocationModel model)
    {
        
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
    [HttpDelete("{pointId}")]
    public IActionResult Delete(long pointId)
    {
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
}




[ApiController]
[Route("registration")]
public class AuthController : ControllerBase
{
    
    public IActionResult Post([FromBody]CreateLocationModel model)
    {
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
    [HttpPut("{pointId}")]
    public IActionResult Put([FromBody]UpdatedLocationModel model)
    {
        
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
    [HttpDelete("{pointId}")]
    public IActionResult Delete(long pointId)
    {
        return new ObjectResult(new LocationModel {
            Id = 1L,
            Latitude = 1D   ,
            Longitude = 1D
        });
    }
}