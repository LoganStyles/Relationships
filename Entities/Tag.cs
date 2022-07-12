using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships
{
    public class Tag
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("TagId")]
        [InverseProperty(nameof(Album.CompilationTags))]
        public ICollection<Album> CompilationAlbums { get; set; }

        [ForeignKey("TagId")]
        [InverseProperty(nameof(Album.MixtapeTags))]
        public ICollection<Album> MixtapeAlbums { get; set; }

        [ForeignKey("TagId")]
        [InverseProperty(nameof(Album.VideoTags))]
        public ICollection<Album> VideoAlbums { get; set; }
    }
}














