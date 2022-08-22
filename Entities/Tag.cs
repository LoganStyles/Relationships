namespace Relationships
{
    public class Tag
    {
        public long TagId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<AlbumTag> AlbumTags { get; set; }
        
    }
}
