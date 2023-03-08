using Mapster;
using Microsoft.AspNetCore.Mvc;
using Web.DbContexts;


namespace Web.Models;

public class UpdatedLocationModel
{
    [FromRoute(Name = "pointId")]
    public long PointId { get; set;}
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
