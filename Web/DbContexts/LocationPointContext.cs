

using Microsoft.EntityFrameworkCore;

namespace Web.DbContexts;

public class LocationPointContext : DbContext
{
    public LocationPointContext(DbContextOptions<LocationPointContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<LocationPoint> LocationPoints { get; set; } = null!;
}
