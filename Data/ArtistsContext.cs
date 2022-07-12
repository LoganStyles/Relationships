using Microsoft.EntityFrameworkCore;

namespace Relationships.Data
{
    public partial class ArtistsContext : DbContext
    {
        public ArtistsContext() { }

        public ArtistsContext(DbContextOptions<ArtistsContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumTag>().HasKey(at => new { at.AlbumId, at.TagId });

            modelBuilder
                .Entity<AlbumTag>()
                .HasOne(al => al.Album)
                .WithMany(a => a.AlbumTags)
                .HasForeignKey(al => al.AlbumId);

            modelBuilder
                .Entity<AlbumTag>()
                .HasOne(tg => tg.Tag)
                .WithMany(t => t.AlbumTags)
                .HasForeignKey(tg => tg.TagId);
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













