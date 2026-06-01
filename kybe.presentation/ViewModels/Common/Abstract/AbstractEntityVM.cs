using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.ViewModels.Common.Abstract
{
    public class AbstractEntityVM
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; } = null;
        public bool IsActive { get; set; } = true;
        protected AbstractEntityVM() { }
        public bool SetActive() => IsActive = true;
        public bool SetInactive() => IsActive = false;
        public void SetUpdate() => UpdateAt = DateTime.UtcNow;
    }
}
