using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace template_csharp_album_collections.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context; 
        }

        
    }
}
