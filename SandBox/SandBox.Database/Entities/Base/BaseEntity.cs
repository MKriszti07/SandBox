namespace SandBox.Database.Entities.Base
{
    public abstract class BaseEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
