

using Microsoft.EntityFrameworkCore;

namespace Web.DbContexts;


public class Acount
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}

public class Animal
{
    public long Id { get; set; }

    public ICollection<AnimalType> AnimalTypes { get; set; } = null!;

    public float Weight { get; set; } 

    public float Length { get; set; }

    public float Height { get; set; } 

    public GenderType Gender { get; set; }

    public LifeStatusType LifeStatus { get; set; } 

    public DateTime ChippingDateTime { get; set; }

    public int? ChipperId { get; set; } //account

    public Acount? Chipper { get; set; } //account

    public long? ChippingLocationId { get; set; } //location

    public LocationPoint? ChippingLocation { get; set; } //location

    public ICollection<LocationAndAnimal> VisitedLocations { get; set; } = null!;

    public DateTime DeathDateTime { get; set; }

    public enum GenderType
    {
        MALE = default,
        FEMALE,
        OTHER
    }

    public enum LifeStatusType
    {
        ALIVE = default,
        DEAD,
    }
}

public class LocationAndAnimal 
{
    public long AnimalId { get; set; }

    public DateTime DateTimeOfVisitLocationPoint { get; set; }

    public long LocationPointId { get; set; }
}

public class LocationPoint
{
    public long Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public class AnimalType
{
    public long Id { get; set; }
    public string Type { get; set; } = null!;
}



public class AnimalContext : DbContext
{
    public AnimalContext(DbContextOptions<AnimalContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>().HasMany(p => p.AnimalTypes).WithMany();
        modelBuilder.Entity<Animal>().HasOne(e => e.Chipper).WithMany().HasForeignKey(k => k.ChipperId);
        modelBuilder.Entity<Animal>().HasOne(e => e.ChippingLocation).WithMany().HasForeignKey(k => k.ChippingLocation);
        modelBuilder.Entity<Animal>().HasMany(e => e.VisitedLocations).WithOne().HasForeignKey(k => k.AnimalId);

        modelBuilder.Entity<LocationPoint>().HasMany<LocationAndAnimal>().WithOne().HasForeignKey(l => l.LocationPointId);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Acount> Accounts { get; set; } = null!;
    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<LocationAndAnimal> LocationAndAnimals { get; set; } = null!;
    public DbSet<LocationPoint> LocationPoints { get; set; } = null!;
    public DbSet<AnimalType> AnimalTypes { get; set; } = null!; 
}