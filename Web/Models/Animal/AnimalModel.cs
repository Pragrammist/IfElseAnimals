namespace Web.Models;

public class AnimalModel
{
    public long Id { get; set; }

    public IEnumerable<long> AnimalTypes { get; set; } = new long[0];

    public float Weight { get; set; } 

    public float Length { get; set; }

    public float Height { get; set; } 

    public string Gender { get; set; } = "MALE"; // "FEMALE" "OTHER"

    public string LifeStatus { get; set; } = "ALIVE"; // "DEAD"

    public DateTime ChippingDateTime { get; set; }

    public int ChipperId { get; set; } //account

    public long ChippingLocationId { get; set; } //location

    public IEnumerable<long> VisitedLocations { get; set; } = new long[0];

    public DateTime DeathDateTime { get; set; }
}
