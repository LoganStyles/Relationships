namespace Relationships
{
    public class Tag
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Album> Albums { get; set; }
        
    }
}














