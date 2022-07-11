using Microsoft.EntityFrameworkCore;

namespace Relationships
{
    [Index(nameof(EmployeeId), IsUnique = true)]
    public class Studio
    {
        public long Id { get; set; }
        public long HouseNumber { get; set; }
        public string City { get; set; }

        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
