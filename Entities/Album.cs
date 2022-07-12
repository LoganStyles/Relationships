using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships
{
    public class Album
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        [ForeignKey("AlbumId")]
        [InverseProperty(nameof(Tag.CompilationAlbums))]
        public ICollection<Tag> CompilationTags { get; set; }

        [ForeignKey("AlbumId")]
        [InverseProperty(nameof(Tag.MixtapeAlbums))]
        public ICollection<Tag> MixtapeTags { get; set; }

        [ForeignKey("AlbumId")]
        [InverseProperty(nameof(Tag.VideoAlbums))]
        public ICollection<Tag> VideoTags { get; set; }
    }
}














