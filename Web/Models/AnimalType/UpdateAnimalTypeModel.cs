using Mapster;
using Microsoft.AspNetCore.Mvc;
using Web.DbContexts;

namespace Web.Models;


public class UpdateAnimalTypeModel
{
    
    public long AnimalId { get; set; }
    public string Type { get; set; } = null!;
}