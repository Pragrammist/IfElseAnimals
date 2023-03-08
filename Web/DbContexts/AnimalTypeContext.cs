

using Microsoft.EntityFrameworkCore;

namespace Web.DbContexts;

public class AnimalTypeContext : DbContext
{
    public AnimalTypeContext(DbContextOptions<AnimalTypeContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}
