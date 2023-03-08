using Microsoft.AspNetCore.Mvc;

namespace Web.Models;

public class UpdateAnimalLocationModel 
{
    [FromQuery(Name = "animalId")]
    public long Id { get; set; }

    public long VisitedLocationPointId { get; set; }

    public long LocationPointId { get; set; }
}