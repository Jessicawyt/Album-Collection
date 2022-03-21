using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using template_csharp_album_collections.Models;

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

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.Songs.ToList();
        }

        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return _context.Songs.Find(id);
        }

        [HttpPost]
        public bool Post(Song song)
        {
            try
            {
                _context.Songs.Add(song);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        [HttpPut]
        public bool Put(Song song)
        {
            try
            {
                _context.Songs.Update(song);
                _context.SaveChanges(true);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        [HttpDelete("{id}")]
        public IEnumerable<Song> Delete(int id)
        {
        
            var songToDelete = _context.Songs.Find(id);
            _context.Songs.Remove(songToDelete);
            _context.SaveChanges();
            return _context.Songs.ToList();

    
 

        }
    }
}
