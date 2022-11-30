using SandBox.Database.Interfaces.Base;

namespace SandBox.Database.Entities.Base
{
    public abstract class DeleteEntity<T> : BaseEntity<T>, IDeleteEntity
    {
        public bool IsDeleted { get; set; }
    }
}
