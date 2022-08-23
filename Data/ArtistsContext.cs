using Microsoft.EntityFrameworkCore;

namespace Relationships.Data
{
    public partial class ArtistsContext : DbContext
    {
        public ArtistsContext() { }

        public ArtistsContext(DbContextOptions<ArtistsContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Employee>()
                .HasMany(a => a.SeniorEmployeeAlbums)
                .WithOne(e => e.SeniorEmployee)
                .HasForeignKey(emp => emp.SeniorEmployeeId);

            modelBuilder
                .Entity<Employee>()
                .HasMany(a => a.JuniorEmployeeAlbums)
                .WithOne(e => e.JuniorEmployee)
                .HasForeignKey(emp => emp.JuniorEmployeeId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("data source=output/Artists.db");
            }
        }
    }
}
