namespace template_csharp_album_collections.Models
{
    public class Artist
    {
        public int Id;
        public string Name;
        public string Genre;
        public string Bio;
        public string HeroImage;
        //public virtual List<Albums> Albums; //Albums will have relationship to Songs
    }
}
