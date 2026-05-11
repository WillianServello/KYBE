namespace kybe_domain.Entity.Abstract
{
    public abstract class GenericEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CreateAt { get; private set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; private set; } = null;
        public bool IsActive { get; private set; } = true;
        protected GenericEntity() { }

        public bool SetActive() => IsActive = true;
        public bool SetInactive() => IsActive = false;
        public void SetUpdate() => UpdateAt = DateTime.UtcNow;

    }
}
