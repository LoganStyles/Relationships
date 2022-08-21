using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Age { get; set; }


        [InverseProperty("SeniorEmployee")]
        public ICollection<Album> SeniorEmployeeAlbums { get; set; }


        [InverseProperty("JuniorEmployee")]
        public ICollection<Album> JuniorEmployeeAlbums { get; set; }
    }
}
