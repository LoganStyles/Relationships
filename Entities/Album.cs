using System.Collections.Generic;

namespace Relationships
{
    public class Album
    {
        public long AlbumId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public ICollection<AlbumTag> AlbumTags { get; set; }
    }
}














