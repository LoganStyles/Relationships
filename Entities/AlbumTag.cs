namespace Relationships
{
    public class AlbumTag{
        public long AlbumId { get; set; }
        public Album Album { get; set; }

        public long TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
