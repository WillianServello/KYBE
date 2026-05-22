using kybe.presentation.ViewModels.Abstract;

namespace kybe.presentation.ViewModels.Entity.Track.Create
{
    public sealed class TrackCreateVM : AbstractEntityVM
    {
        public IFormFile TrackFile { get; set; } = null!;
    }
}
