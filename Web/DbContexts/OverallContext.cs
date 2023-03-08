

using Microsoft.EntityFrameworkCore;

namespace Web.DbContexts;

public class OverallContex : DbContext
{
    public OverallContex(DbContextOptions<OverallContex> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Account> Accounts { get; set; } = null!;
    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<Animal> LocationAndAnimals { get; set; } = null!;
    public DbSet<LocationPoint> LocationPoints { get; set; } = null!;
    public DbSet<AnimalType> AnimalTypes { get; set; } = null!;
    
    
    public class Account
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

        public int ChipperId { get; set; } //account

        public long ChippingLocationId { get; set; } //location

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
        public Animal Animal { get; set; } = null!;


        public DateTime DateTimeOfVisitLocationPoint { get; set; }


        public long LocationPointId { get; set; }
        public LocationPoint LocationPoint { get; set; } = null!;
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
}