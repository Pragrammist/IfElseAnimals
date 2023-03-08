using Microsoft.AspNetCore.Mvc;
namespace Web.Models;

public class UpdateAnimalModel
{
    [FromRoute(Name = "animalId")]
    public long Id { get; set; }

    public IEnumerable<long> AnimalTypes { get; set; } = new long[0];

    public float Weight { get; set; } 

    public float Length { get; set; }

    public float Height { get; set; } 

    public string Gender { get; set; } = "MALE"; // "FEMALE" "OTHER"

    public int ChipperId { get; set; } //account

    public long ChippingLocationId { get; set; } //location

}
