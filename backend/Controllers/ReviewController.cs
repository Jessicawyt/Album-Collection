using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using template_csharp_album_collections.Models;

namespace template_csharp_album_collections.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return _context.Reviews.ToList();
        }

        [HttpGet("{id}")]
        public Review Get(int id)
        {
            return _context.Reviews.Find(id);
        }

        [HttpPost]
        public bool Post(Review review)
        {
            try
            {
                _context.Reviews.Add(review);
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
