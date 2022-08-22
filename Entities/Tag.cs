using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships
{
    public class Tag
    {
        [Key]
        public long TID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("TID")]
        [InverseProperty(nameof(Album.Tags))]
        public ICollection<Album> Albums { get; set; }
    }
}
