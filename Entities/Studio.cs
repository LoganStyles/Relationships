using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Relationships
{
    [Index(nameof(EmployeeId), IsUnique = true)]
    public class Studio
    {
        public long Id { get; set; }
        public long HouseNumber { get; set; }
        public string City { get; set; }

        [ForeignKey("Employee")]
        public long EmployeeId { get; set; }

        [InverseProperty("Studio")]
        public Employee Employee { get; set; }
    }
}














