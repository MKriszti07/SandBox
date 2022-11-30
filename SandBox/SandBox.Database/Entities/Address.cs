using SandBox.Database.Entities.Base;

namespace SandBox.Database.Entities
{
    public class Address : AuditEntity<Guid>
    {
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
