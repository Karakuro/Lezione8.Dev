namespace Lezione8.Dev.Data
{
    public class Genre
    {
        public int GenreId { get; set; }
        public required string Name { get; set; }
        public List<Shelf>? Shelves { get; set; }
    }
}
