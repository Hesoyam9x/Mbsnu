using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    public DbSet<OilVolume> OilVolumes => Set<OilVolume>();
    public AppContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=helloapp.db");
    }
}