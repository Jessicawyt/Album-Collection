using System.Collections.Generic;

namespace template_csharp_album_collections.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Bio { get; set; }
        public string HeroImage { get; set; }
        public virtual List<Album> Albums { get; set; }
}
}
