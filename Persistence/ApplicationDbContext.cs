using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // *** Windows Authentication Mode
        var connectionString =
            "Server=.;" +
            "Database = Mini_Project;" +
            "MultipleActiveResultSets = true;" +
            "Trusted_Connection = True;" +
            "TrustServerCertificate = True; ";

        // *** SQL Server Authentication Mode
        //var connectionString =
        //    "Server=.;" +
        //    "User ID=sa;" +
        //    "Password=1234512345;" +
        //    "Database=Mini_Project;" +
        //    "MultipleActiveResultSets=true;" +
        //    "TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer(connectionString: connectionString);

    }
}
