namespace Relationships
{
    public class Studio
    {
        public long Id { get; set; }
        public long HouseNumber { get; set; }
        public string City { get; set; }

        public long EmpId { get; set; }
        public Employee Employee { get; set; }
        
    }
}
