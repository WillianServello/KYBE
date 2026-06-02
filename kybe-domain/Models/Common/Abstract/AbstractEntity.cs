namespace kybe_domain.Models.Common.Abstract
{
    public abstract class AbstractEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CreateAt { get; private set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; private set; } = null;
        public bool IsActive { get; private set; } = true;
        protected AbstractEntity() { }

        public bool SetActive() => IsActive = true;
        public bool SetInactive() => IsActive = false;
        public void SetUpdate() => UpdateAt = DateTime.UtcNow;

    }
}
