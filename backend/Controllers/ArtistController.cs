using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using template_csharp_album_collections.Models;
using System;

namespace template_csharp_album_collections.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Artist> Get()
        {
            return _context.Artists.ToList();
        }

        [HttpGet("{id}")]
        public Artist Get(int id)
        {
            return _context.Artists.Find(id);
        }

        [HttpPost]
        public bool Post(Artist artist)
        {
            try
            {
                _context.Artists.Add(artist);
                _context.SaveChanges();
                return true;
            }

            catch (Exception e)
            {
                //error handling
                return false;
            }
        }

        [HttpPut]
        public bool Put(Artist artist)
        {
            try
            {
                _context.Update(artist);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var artistToDelete = _context.Artists.Find(id);
            _context.Artists.Remove(artistToDelete);
            _context.SaveChanges();
        }
    }
}
