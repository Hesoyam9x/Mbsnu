using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    public DbSet<Kit> Kits { get; set; } = null!;
    public DbSet<Cistern> Cisterns { get; set; } = null!;
    public DbSet<OilVolume> OilVolumes { get; set; } = null!;

    public AppContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=appdb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OilVolume>(entity =>
        {
           /* entity.HasKey(o => o.OilVolumeId);*/

            entity.Property(o => o.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        });
        modelBuilder.Entity<Cistern>(entity =>
        {
            entity.Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        });
       /* modelBuilder.Entity<Kit>(entity =>
        {
            entity.Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        });*/
    }
}