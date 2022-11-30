using SandBox.Database.Interfaces.Base;

namespace SandBox.Database.Entities.Base
{
    public abstract class AuditEntity<T> : DeleteEntity<T>, IAuditEntity
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
