using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using template_csharp_album_collections.Models;

namespace template_csharp_album_collections.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private ApplicationDbContext _context;

        public AlbumController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return _context.Albums.ToList();

        }


        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return _context.Albums.Find(id);
        }


        [HttpPost]
        public Album Post(Album album)
        {
            try
            {
                _context.Albums.Add(album);
                _context.SaveChanges();

                return album;
            }
            catch (Exception)
            {
             
              return new Album();
            }

        }

        [HttpPut]
        public Album Put(Album album)
        {
            try
            {
                _context.Update(album);
                _context.SaveChanges();
                return album;
            }
            catch (Exception)
            {
                return new Album();
            }
        }

        [HttpDelete("{id}")]
        public IEnumerable<Album> Delete(int id)
        {
            var albumToDelete = _context.Albums.Find(id);
            _context.Albums.Remove(albumToDelete);
            _context.SaveChanges();
            return _context.Albums.ToList();
        }
    }
}
