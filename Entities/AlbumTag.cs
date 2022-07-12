namespace Relationships
{
    public class AlbumTag{
        public long AlbumId { get; set; }
        public Album Albums { get; set; }

        public long TagId { get; set; }
        public Tag Tags { get; set; }
    }
}