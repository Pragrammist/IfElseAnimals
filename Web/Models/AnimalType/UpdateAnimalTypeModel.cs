using Microsoft.AspNetCore.Mvc;

public class UpdateAnimalTypeModel
{
    [FromRoute(Name = "animalId")]
    public long Id { get; set; }
    public string Type { get; set; } = null!;
}