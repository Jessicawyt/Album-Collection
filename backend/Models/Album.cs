using System.Collections.Generic;

namespace template_csharp_album_collections.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string Image { get; set; }
        
        public string RecordLabel { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        
        public virtual IEnumerable<Song> Songs { get; set; }
        public virtual IEnumerable<Review> Reviews { get; set; }


    }
}
