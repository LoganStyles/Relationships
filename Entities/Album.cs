namespace Relationships
{
    public class Album
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public long SeniorEmployeeId { get; set; }
        public Employee SeniorEmployee { get; set; }
        
        public long JuniorEmployeeId { get; set; }
        public Employee JuniorEmployee { get; set; }
    }
}
