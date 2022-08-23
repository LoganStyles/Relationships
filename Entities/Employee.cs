namespace Relationships
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Age { get; set; }

        public ICollection<Album> SeniorEmployeeAlbums { get; set; }
        public ICollection<Album> JuniorEmployeeAlbums { get; set; }
    }
}
