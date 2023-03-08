using Mapster;
using Microsoft.AspNetCore.Mvc;
using Web.DbContexts;

namespace Web.Models;

public class UpdateAccountModel
{
    public string? FirstName { get; set; }   
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}
