using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.Controllers.Track
{
    public class TrackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
