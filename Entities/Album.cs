namespace Relationships
{
    public class Album
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
