using Microsoft.AspNetCore.Mvc;

namespace template_csharp_album_collections.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
