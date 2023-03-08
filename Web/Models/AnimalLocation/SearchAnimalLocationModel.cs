using Microsoft.AspNetCore.Mvc;

namespace Web.Models;

public class SearchAnimalLocationModel 
{
    [FromQuery]
    public long AnimalId { get; set;}
    
    public DateTime? StartDateTime { get; set;}

    public DateTime? EndDateTime { get; set;}

    public int From { get; set; } = 0;

    public int Size { get; set; } = 10;
}
