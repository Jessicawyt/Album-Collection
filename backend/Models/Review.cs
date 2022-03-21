namespace template_csharp_album_collections.Models
{
    public class Review
    {
        public int Id { get; set; } 
        public string ReviewerName { get; set; }
        public string Content { get; set; } 
        public int AlbumId { get; set; }    
        public virtual Album Album { get; set; }
    }
}
