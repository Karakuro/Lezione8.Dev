namespace Lezione8.Dev.Data
{
    public class Shelf
    {
        public int ShelfId { get; set; }
        public required string Name { get; set; }
        public int? GenreId { get; set; }
        public List<Book>? Books { get; set; }
        public Genre? Genre { get; set; }
    }
}
