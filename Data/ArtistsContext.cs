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
                .HasOne(e => e.Album)
                .WithOne(e => e.Employee)
                .HasForeignKey<Album>(emp => emp.EmployeeId);
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
