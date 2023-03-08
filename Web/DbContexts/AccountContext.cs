

using Microsoft.EntityFrameworkCore;

namespace Web.DbContexts;

public class AccountContext : DbContext
{
    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Acount> Accounts { get; set; } = null!;
}
