using Microsoft.AspNetCore.Mvc;
namespace Web.Models;

public class UpdatedLocationModel
{
    [FromRoute(Name = "pointId")]
    public long Id { get; set;}
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
