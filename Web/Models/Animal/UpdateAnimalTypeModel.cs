using Microsoft.AspNetCore.Mvc;
namespace Web.Models;

public class UpdateAnimalTypeModel
{
    [FromRoute(Name = "animalId")]
    public long Id { get; set; }

    public long OldTypeId { get; set; }

    public long NewTypeId { get; set; }
}