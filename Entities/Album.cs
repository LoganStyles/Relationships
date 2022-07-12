using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships
{
    public class Album
    {
        [Key]
        public long AlbID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        [ForeignKey("AlbID")]
        [InverseProperty(nameof(Tag.Albums))]
        public ICollection<Tag> Tags { get; set; }

    }
}














