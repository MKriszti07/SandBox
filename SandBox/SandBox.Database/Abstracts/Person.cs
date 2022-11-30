using SandBox.Database.Entities;
using SandBox.Database.Entities.Base;

namespace SandBox.Database.Abstracts
{
    public abstract class Person : AuditEntity<Guid>
    {
        public virtual Address Address { get; set; } = default!;
        public virtual DateOnly? DateOfBirth { get; set; } = default!;
        public virtual string Email { get; set; } = default!;
        public virtual string FamilyName { get; set; } = default!;
        public virtual string GivenName { get; set; } = default!;
        public virtual string MotherFamilyName { get; set; } = default!;
        public virtual string MotherGivenName { get; set; } = default!;
        public virtual string PhoneNumber { get; set; } = default!;
    }
}
